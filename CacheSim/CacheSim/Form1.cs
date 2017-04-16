using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacheSim
{
    public partial class Form1 : Form
    {
        CacheBlockStruct[] Block = new CacheBlockStruct[65536];
        CacheStruct cache = new CacheStruct();
        Result result = new Result();
        bool[] Block_Fill = new bool[65536];
        System.IO.StreamReader file;
        System.IO.StreamWriter file1 = new System.IO.StreamWriter("1.txt");

        uint time;
        uint OutWay;
        uint Block_Num;
        uint Way_num;
        uint Curr_tag;
        int Curr_Lable;
        uint Curr_Address;
        Operator op=new Operator();
        public Form1()
        {
            InitializeComponent();
            DefaultSetting();

                
        }
        public void DefaultSetting()
        {
            time = 0;
            for (int i = 0; i < 65536; i++)
            {
                Block[i] = new CacheBlockStruct();
                Block[i].flag = 0;
                Block[i].tag = 0;
            }
            cbBox_Totle.SelectedIndex = 5;
            cbBox_Data.SelectedIndex = 5;
            cbBox_Instruct.SelectedIndex = 5;
            cbBox_Block.SelectedIndex = 1;
            cbBox_Link.SelectedIndex = 0;
            cbBox_Replace.SelectedIndex = 0;
            cbBox_Pre.SelectedIndex = 0;
            cbBox_Unhit.SelectedIndex = 0;
            cbBox_Write.SelectedIndex = 0;
            cbBox_Visit.SelectedIndex = 0;
            textBox_Total_Num.Text = "0";
            textBox_Total_Unhit.Text = "0";
            textBox_Total_UnhitRate.Text = "0.00%";
            textBox_RI_Num.Text = "0";
            textBox_RI_Unhit.Text = "0";
            textBox_RI_UnhitRate.Text = "0.00%";
            textBox_RD_Num.Text = "0";
            textBox_RD_Unhit.Text = "0";
            textBox_RD_UnhitRate.Text = "0.00%";
            textBox_WD_Num.Text = "0";
            textBox_WD_Unhit.Text = "0";
            textBox_WD_UnhitRate.Text = "0.00%";
            for (int i=0; i < 65536; i++)
                Block_Fill[i] = false;
        }
        public void UpdateData()
        {
            cache.Usize = (uint)(2048 << cbBox_Totle.SelectedIndex);
            cache.assoc = (uint)(1 << cbBox_Link.SelectedIndex);
            cache.blockSize = (uint)(16 << cbBox_Block.SelectedIndex);
            if (cbBox_Replace.SelectedIndex == 0)
                cache.replace = CacheReplace.LRU;
            else 
                cache.replace = CacheReplace.FIFO;
            if (cbBox_Unhit.SelectedIndex == 0)
                cache.unHit = CacheNotHit.WriteAlloc;
            else
                cache.unHit = CacheNotHit.NotWriteAlloc;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cbBox_Totle.Enabled = true;
                cbBox_Data.Enabled = false;
                cbBox_Instruct.Enabled = false;
            }
            else
            {
                cbBox_Totle.Enabled = false;
                cbBox_Data.Enabled = true;
                cbBox_Instruct.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private Operator To_op(int index)
        {
            switch (index)
            {
                case 0: return Operator.RD;
                case 1: return Operator.WD;
                default: return Operator.RI;
            }
        }
        private uint Find(uint addr)
        {
            uint block0;
            OutWay = (addr / cache.blockSize) % Way_num;
            Curr_tag = addr / cache.blockSize;
            for (uint i = 0; i < cache.assoc; i++)
            {
                block0 = OutWay*cache.assoc + i;
                if (Block_Fill[block0] == true)
                {
                    if (Block[block0].tag == Curr_tag)
                        return block0;
                }
            }
            return Block_Num+2;
        }
        private uint Find_Empty()
        {
            uint block0;
            for (uint i = 0; i < cache.assoc; i++)
            {
                block0 = OutWay*cache.assoc + i;
                if (Block_Fill[block0] == false)
                    return block0;
            }
            return Block_Num + 2;
        }
        private void Hand_Click(object sender, EventArgs e)
        {
            uint addr;
            UpdateData();
            uint t,block1;
            time++;
            Block_Num = cache.Usize / cache.blockSize;
            Way_num = Block_Num / cache.assoc;
            addr = Convert.ToUInt32(Hand_Addr.Text.ToString());
            Curr_Address = addr;
            op = To_op(cbBox_Visit.SelectedIndex);
            block1 = Find(addr);
            if (block1 > Block_Num)
            {
                if (cache.unHit == CacheNotHit.WriteAlloc || op != Operator.WD)
                {
                    t = Find_Empty();
                    if (t < Block_Num)
                        Replace_Block(t, Curr_Address);
                    else
                        Replace_Block(Get_Replace_Num(), Curr_Address);
                    getResult(op, false);
                }
                else
                {
                    result.block_Num = 0;
                    getResult(op, false);
                }

            }
            else
            {
                Update_Block(block1);
                getResult(op, true);
            }
            Show_Result();
            
        }
        private void Show_Result()
        {
            textBox_Total_Num.Text = result.total_Num.ToString();
            textBox_Total_Unhit.Text = result.total_Unhit.ToString();
            textBox_Total_UnhitRate.Text = result.total_UnhitRate.ToString("F2") + "%";
            textBox_RI_Num.Text = result.readI_Num.ToString();
            textBox_RI_Unhit.Text = result.readI_Unhit.ToString();
            textBox_RI_UnhitRate.Text = result.readI_UnhitRate.ToString("F2") + "%";
            textBox_RD_Num.Text = result.readD_Num.ToString();
            textBox_RD_Unhit.Text = result.readD_Unhit.ToString();
            textBox_RD_UnhitRate.Text = result.readD_UnhitRate.ToString("F2") + "%";
            textBox_WD_Num.Text = result.writeD_Num.ToString();
            textBox_WD_Unhit.Text = result.writeD_Unhit.ToString();
            textBox_WD_UnhitRate.Text = result.writeD_UnhitRate.ToString("F2") + "%";
            textBox_Block_Num.Text = result.block_Num.ToString();
        }
        private void Update_Block(uint i)
        {
            result.block_Num = i;
            if (cache.replace == CacheReplace.LRU)
                Block[i].flag = time;
        }
        private uint Get_Replace_Num()
        {
            uint t,block0;
            t = OutWay*cache.assoc;
            for (uint i = 1; i < cache.assoc; i++)
            {
                block0 = OutWay*cache.assoc + i;
                if (Block[t].flag > Block[block0].flag)
                    t = block0;
            }
            return t;
        }
        private void Replace_Block(uint t,uint addr)
        {
            Block_Fill[t] = true;
            Block[t].flag = time;
            Block[t].tag = (addr / cache.blockSize);
            result.block_Num = t;
        }
        private void getResult(Operator op1,bool hit)
        {
            result.total_Num++;
            if (hit)
            {
                switch (op1)
                {
                    case Operator.RI:
                        result.readI_Num++;
                        break;
                    case Operator.RD:
                        result.readD_Num++;
                        break;
                    case Operator.WD:
                        result.writeD_Num++;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                result.total_Unhit++;
                switch (op1)
                {
                    case Operator.RI:
                        result.readI_Num++;
                        result.readI_Unhit++;
                        break;
                    case Operator.RD:
                        result.readD_Num++;
                        result.readD_Unhit++;
                        break;
                    case Operator.WD:
                        result.writeD_Num++;
                        result.writeD_Unhit++;
                        break;
                    default:
                        break;
                }
            }
            result.total_UnhitRate = (result.total_Num == 0) ? 0:(((double)result.total_Unhit/result.total_Num) * 100);
            result.readD_UnhitRate = (result.readD_Num == 0) ? 0 : (((double)result.readD_Unhit / result.readD_Num) * 100);
            result.readI_UnhitRate = (result.readI_Num == 0) ? 0 : ((double)result.readI_Unhit / result.readI_Num * 100);
            result.writeD_UnhitRate = (result.writeD_Num == 0) ? 0 : ((double)result.writeD_Unhit / result.writeD_Num * 100);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            textBox_addr.Text = openFileDialog1.FileName;
            file = new System.IO.StreamReader(openFileDialog1.FileName);
        }


        private void cbBox_Replace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            cbBox_Totle.SelectedIndex = 5;
            cbBox_Data.SelectedIndex = 5;
            cbBox_Instruct.SelectedIndex = 5;
            cbBox_Block.SelectedIndex = 0;
            cbBox_Link.SelectedIndex = 0;
            cbBox_Replace.SelectedIndex = 0;
            cbBox_Pre.SelectedIndex = 0;
            cbBox_Unhit.SelectedIndex = 0;
            cbBox_Write.SelectedIndex = 0;
            cbBox_Visit.SelectedIndex = 0;
            DefaultSetting();
            result = new Result();
        }

        private void Step_Click(object sender, EventArgs e)
        {
            uint block1,t;
            UpdateData();
            time++;
            Block_Num = cache.Usize / cache.blockSize;
            Way_num = Block_Num / cache.assoc;
            if (!ReadOneAddr())
                return;
            op = To_op(Curr_Lable);
            block1 = Find(Curr_Address);
            if (block1 > Block_Num)
            {
                if (cache.unHit == CacheNotHit.WriteAlloc || op !=Operator.WD )
                {
                    t = Find_Empty();
                    if (t < Block_Num)
                        Replace_Block(t, Curr_Address);
                    else
                        Replace_Block(Get_Replace_Num(), Curr_Address);
                    getResult(op, false);
                }
                else
                {
                    getResult(op, false);
                }
                
            }
            else
            {
                Update_Block(block1);
                getResult(op, true);
            }
            Show_Result();
        }
        private bool ReadOneAddr()
        {
            string str = file.ReadLine();
            if (str == null)
                return false;
            char[] chArray = new char[2] { ' ', '\t' };
            string[] strArray = str.Split(chArray);
            Curr_Lable = int.Parse(strArray[0]);
            Curr_Address = uint.Parse(strArray[1], System.Globalization.NumberStyles.HexNumber);
            return true;
        }

        private void FULL_Click(object sender, EventArgs e)
        {
            uint block1, t;
            UpdateData();
            Block_Num = cache.Usize / cache.blockSize;
            Way_num = Block_Num / cache.assoc;
            while (ReadOneAddr())
            {
                time++;
                op = To_op(Curr_Lable);
                block1 = Find(Curr_Address);
                if (block1 > Block_Num)
                {
                    if (cache.unHit == CacheNotHit.WriteAlloc || op != Operator.WD)
                    {
                        t = Find_Empty();
                        if (t < Block_Num)
                            Replace_Block(t, Curr_Address);
                        else
                            Replace_Block(Get_Replace_Num(), Curr_Address);
                        getResult(op, false);
                    }
                    else
                    {
                        getResult(op, false);
                    }
                    file1.WriteLine(time.ToString()+" "+Curr_Address.ToString());
                }
                else
                {
                    Update_Block(block1);
                    getResult(op, true);
                }
            }
            Show_Result();
          //  MessageBox.Show(time.ToString());
        }

        private void textBox_Block_Num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
