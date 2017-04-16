namespace CacheSim
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.cbBox_Block = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBox_Link = new System.Windows.Forms.ComboBox();
            this.cbBox_Replace = new System.Windows.Forms.ComboBox();
            this.cbBox_Pre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBox_Write = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBox_Unhit = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBox_Totle = new System.Windows.Forms.ComboBox();
            this.cbBox_Instruct = new System.Windows.Forms.ComboBox();
            this.cbBox_Data = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbBox_Visit = new System.Windows.Forms.ComboBox();
            this.Hand = new System.Windows.Forms.Button();
            this.Hand_Addr = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FULL = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_Total_Num = new System.Windows.Forms.TextBox();
            this.textBox_Total_Unhit = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_Total_UnhitRate = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_WD_UnhitRate = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_WD_Unhit = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_WD_Num = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_RD_UnhitRate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_RD_Unhit = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_RD_Num = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_RI_UnhitRate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_RI_Unhit = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_RI_Num = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Reset = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.Curr_Instruct = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_Block_Num = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "块大小：";
            // 
            // cbBox_Block
            // 
            this.cbBox_Block.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Block.FormattingEnabled = true;
            this.cbBox_Block.Items.AddRange(new object[] {
            "16B",
            "32B",
            "64B",
            "128B",
            "256B"});
            this.cbBox_Block.Location = new System.Drawing.Point(182, 148);
            this.cbBox_Block.Name = "cbBox_Block";
            this.cbBox_Block.Size = new System.Drawing.Size(130, 20);
            this.cbBox_Block.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "相连度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "替换策略：";
            // 
            // cbBox_Link
            // 
            this.cbBox_Link.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Link.FormattingEnabled = true;
            this.cbBox_Link.Items.AddRange(new object[] {
            "直接映像",
            "2路",
            "4路",
            "8路",
            "16路",
            "32路"});
            this.cbBox_Link.Location = new System.Drawing.Point(183, 180);
            this.cbBox_Link.Name = "cbBox_Link";
            this.cbBox_Link.Size = new System.Drawing.Size(130, 20);
            this.cbBox_Link.TabIndex = 6;
            // 
            // cbBox_Replace
            // 
            this.cbBox_Replace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Replace.FormattingEnabled = true;
            this.cbBox_Replace.Items.AddRange(new object[] {
            "LRU",
            "FIFO",
            "RAND"});
            this.cbBox_Replace.Location = new System.Drawing.Point(182, 212);
            this.cbBox_Replace.Name = "cbBox_Replace";
            this.cbBox_Replace.Size = new System.Drawing.Size(130, 20);
            this.cbBox_Replace.TabIndex = 7;
            this.cbBox_Replace.SelectedIndexChanged += new System.EventHandler(this.cbBox_Replace_SelectedIndexChanged);
            // 
            // cbBox_Pre
            // 
            this.cbBox_Pre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Pre.FormattingEnabled = true;
            this.cbBox_Pre.Items.AddRange(new object[] {
            "不预取",
            "不命中预取"});
            this.cbBox_Pre.Location = new System.Drawing.Point(183, 251);
            this.cbBox_Pre.Name = "cbBox_Pre";
            this.cbBox_Pre.Size = new System.Drawing.Size(130, 20);
            this.cbBox_Pre.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "预取策略：";
            // 
            // cbBox_Write
            // 
            this.cbBox_Write.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Write.FormattingEnabled = true;
            this.cbBox_Write.Items.AddRange(new object[] {
            "写回法",
            "写直达法"});
            this.cbBox_Write.Location = new System.Drawing.Point(183, 288);
            this.cbBox_Write.Name = "cbBox_Write";
            this.cbBox_Write.Size = new System.Drawing.Size(130, 20);
            this.cbBox_Write.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "写策略：";
            // 
            // cbBox_Unhit
            // 
            this.cbBox_Unhit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Unhit.FormattingEnabled = true;
            this.cbBox_Unhit.Items.AddRange(new object[] {
            "按写分配",
            "不按写分配"});
            this.cbBox_Unhit.Location = new System.Drawing.Point(183, 324);
            this.cbBox_Unhit.Name = "cbBox_Unhit";
            this.cbBox_Unhit.Size = new System.Drawing.Size(130, 20);
            this.cbBox_Unhit.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "写不命中的调块策略：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbBox_Totle);
            this.panel1.Controls.Add(this.cbBox_Instruct);
            this.panel1.Controls.Add(this.cbBox_Data);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 130);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbBox_Totle
            // 
            this.cbBox_Totle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Totle.FormattingEnabled = true;
            this.cbBox_Totle.Items.AddRange(new object[] {
            "2KB",
            "4KB",
            "8KB",
            "16KB",
            "32KB",
            "64KB",
            "128KB",
            "256KB",
            "512KB",
            "1M"});
            this.cbBox_Totle.Location = new System.Drawing.Point(170, 2);
            this.cbBox_Totle.Name = "cbBox_Totle";
            this.cbBox_Totle.Size = new System.Drawing.Size(131, 20);
            this.cbBox_Totle.TabIndex = 15;
            // 
            // cbBox_Instruct
            // 
            this.cbBox_Instruct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Instruct.Enabled = false;
            this.cbBox_Instruct.FormattingEnabled = true;
            this.cbBox_Instruct.Items.AddRange(new object[] {
            "1KB",
            "2KB",
            "4KB",
            "8KB",
            "16KB",
            "32KB",
            "64KB",
            "128KB",
            "256KB",
            "512KB"});
            this.cbBox_Instruct.Location = new System.Drawing.Point(169, 98);
            this.cbBox_Instruct.Name = "cbBox_Instruct";
            this.cbBox_Instruct.Size = new System.Drawing.Size(131, 20);
            this.cbBox_Instruct.TabIndex = 23;
            // 
            // cbBox_Data
            // 
            this.cbBox_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Data.Enabled = false;
            this.cbBox_Data.FormattingEnabled = true;
            this.cbBox_Data.Items.AddRange(new object[] {
            "1KB",
            "2KB",
            "4KB",
            "8KB",
            "16KB",
            "32KB",
            "64KB",
            "128KB",
            "256KB",
            "512KB"});
            this.cbBox_Data.Location = new System.Drawing.Point(169, 66);
            this.cbBox_Data.Name = "cbBox_Data";
            this.cbBox_Data.Size = new System.Drawing.Size(131, 20);
            this.cbBox_Data.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "指令Cache大小：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "数据Cache大小：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "独立Cache：";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(17, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "统一Cache的大小：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_addr);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 117);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "访问地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 21);
            this.button1.TabIndex = 31;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(26, 54);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.ReadOnly = true;
            this.textBox_addr.Size = new System.Drawing.Size(188, 21);
            this.textBox_addr.TabIndex = 30;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(14, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 29;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 28;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "手动输入";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "地址流文件：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbBox_Visit);
            this.groupBox3.Controls.Add(this.Hand);
            this.groupBox3.Controls.Add(this.Hand_Addr);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(51, 496);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 121);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "访问控制";
            this.groupBox3.Visible = false;
            // 
            // cbBox_Visit
            // 
            this.cbBox_Visit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Visit.FormattingEnabled = true;
            this.cbBox_Visit.Items.AddRange(new object[] {
            "读数据",
            "写数据",
            "读指令"});
            this.cbBox_Visit.Location = new System.Drawing.Point(82, 38);
            this.cbBox_Visit.Name = "cbBox_Visit";
            this.cbBox_Visit.Size = new System.Drawing.Size(97, 20);
            this.cbBox_Visit.TabIndex = 18;
            // 
            // Hand
            // 
            this.Hand.Location = new System.Drawing.Point(215, 41);
            this.Hand.Name = "Hand";
            this.Hand.Size = new System.Drawing.Size(38, 39);
            this.Hand.TabIndex = 4;
            this.Hand.Text = "访问";
            this.Hand.UseVisualStyleBackColor = true;
            this.Hand.Click += new System.EventHandler(this.Hand_Click);
            // 
            // Hand_Addr
            // 
            this.Hand_Addr.Location = new System.Drawing.Point(82, 68);
            this.Hand_Addr.Name = "Hand_Addr";
            this.Hand_Addr.Size = new System.Drawing.Size(97, 21);
            this.Hand_Addr.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "地址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "访问类型：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FULL);
            this.groupBox2.Controls.Add(this.Step);
            this.groupBox2.Location = new System.Drawing.Point(27, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 121);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "访问控制";
            // 
            // FULL
            // 
            this.FULL.Location = new System.Drawing.Point(159, 46);
            this.FULL.Name = "FULL";
            this.FULL.Size = new System.Drawing.Size(77, 31);
            this.FULL.TabIndex = 1;
            this.FULL.Text = "执行到底";
            this.FULL.UseVisualStyleBackColor = true;
            this.FULL.Click += new System.EventHandler(this.FULL_Click);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(22, 46);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(77, 31);
            this.Step.TabIndex = 0;
            this.Step.Text = "步进";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(498, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 42);
            this.label15.TabIndex = 30;
            this.label15.Text = "模拟结果";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(362, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "访问总次数：";
            // 
            // textBox_Total_Num
            // 
            this.textBox_Total_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Total_Num.Location = new System.Drawing.Point(438, 151);
            this.textBox_Total_Num.Name = "textBox_Total_Num";
            this.textBox_Total_Num.ReadOnly = true;
            this.textBox_Total_Num.Size = new System.Drawing.Size(58, 14);
            this.textBox_Total_Num.TabIndex = 32;
            this.textBox_Total_Num.Text = "0";
            // 
            // textBox_Total_Unhit
            // 
            this.textBox_Total_Unhit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Total_Unhit.Location = new System.Drawing.Point(576, 151);
            this.textBox_Total_Unhit.Name = "textBox_Total_Unhit";
            this.textBox_Total_Unhit.ReadOnly = true;
            this.textBox_Total_Unhit.Size = new System.Drawing.Size(58, 14);
            this.textBox_Total_Unhit.TabIndex = 34;
            this.textBox_Total_Unhit.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(493, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 12);
            this.label17.TabIndex = 33;
            this.label17.Text = "不命中次数：";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBox_Total_UnhitRate
            // 
            this.textBox_Total_UnhitRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Total_UnhitRate.Location = new System.Drawing.Point(695, 149);
            this.textBox_Total_UnhitRate.Name = "textBox_Total_UnhitRate";
            this.textBox_Total_UnhitRate.ReadOnly = true;
            this.textBox_Total_UnhitRate.Size = new System.Drawing.Size(58, 14);
            this.textBox_Total_UnhitRate.TabIndex = 36;
            this.textBox_Total_UnhitRate.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(624, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 35;
            this.label18.Text = "不命中率：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_WD_UnhitRate);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.textBox_WD_Unhit);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.textBox_WD_Num);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.textBox_RD_UnhitRate);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.textBox_RD_Unhit);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.textBox_RD_Num);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.textBox_RI_UnhitRate);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.textBox_RI_Unhit);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.textBox_RI_Num);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(364, 205);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 203);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "其中";
            // 
            // textBox_WD_UnhitRate
            // 
            this.textBox_WD_UnhitRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_WD_UnhitRate.Location = new System.Drawing.Point(343, 141);
            this.textBox_WD_UnhitRate.Name = "textBox_WD_UnhitRate";
            this.textBox_WD_UnhitRate.ReadOnly = true;
            this.textBox_WD_UnhitRate.Size = new System.Drawing.Size(58, 14);
            this.textBox_WD_UnhitRate.TabIndex = 54;
            this.textBox_WD_UnhitRate.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(260, 141);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 53;
            this.label25.Text = "不命中率：";
            // 
            // textBox_WD_Unhit
            // 
            this.textBox_WD_Unhit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_WD_Unhit.Location = new System.Drawing.Point(221, 141);
            this.textBox_WD_Unhit.Name = "textBox_WD_Unhit";
            this.textBox_WD_Unhit.ReadOnly = true;
            this.textBox_WD_Unhit.Size = new System.Drawing.Size(58, 14);
            this.textBox_WD_Unhit.TabIndex = 52;
            this.textBox_WD_Unhit.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(138, 141);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 51;
            this.label26.Text = "不命中次数：";
            // 
            // textBox_WD_Num
            // 
            this.textBox_WD_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_WD_Num.Location = new System.Drawing.Point(93, 139);
            this.textBox_WD_Num.Name = "textBox_WD_Num";
            this.textBox_WD_Num.ReadOnly = true;
            this.textBox_WD_Num.Size = new System.Drawing.Size(58, 14);
            this.textBox_WD_Num.TabIndex = 50;
            this.textBox_WD_Num.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 139);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 12);
            this.label27.TabIndex = 49;
            this.label27.Text = "写数据次数：";
            // 
            // textBox_RD_UnhitRate
            // 
            this.textBox_RD_UnhitRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RD_UnhitRate.Location = new System.Drawing.Point(343, 86);
            this.textBox_RD_UnhitRate.Name = "textBox_RD_UnhitRate";
            this.textBox_RD_UnhitRate.ReadOnly = true;
            this.textBox_RD_UnhitRate.Size = new System.Drawing.Size(58, 14);
            this.textBox_RD_UnhitRate.TabIndex = 48;
            this.textBox_RD_UnhitRate.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(260, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 47;
            this.label22.Text = "不命中率：";
            // 
            // textBox_RD_Unhit
            // 
            this.textBox_RD_Unhit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RD_Unhit.Location = new System.Drawing.Point(221, 86);
            this.textBox_RD_Unhit.Name = "textBox_RD_Unhit";
            this.textBox_RD_Unhit.ReadOnly = true;
            this.textBox_RD_Unhit.Size = new System.Drawing.Size(58, 14);
            this.textBox_RD_Unhit.TabIndex = 46;
            this.textBox_RD_Unhit.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(138, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 12);
            this.label23.TabIndex = 45;
            this.label23.Text = "不命中次数：";
            // 
            // textBox_RD_Num
            // 
            this.textBox_RD_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RD_Num.Location = new System.Drawing.Point(93, 84);
            this.textBox_RD_Num.Name = "textBox_RD_Num";
            this.textBox_RD_Num.ReadOnly = true;
            this.textBox_RD_Num.Size = new System.Drawing.Size(58, 14);
            this.textBox_RD_Num.TabIndex = 44;
            this.textBox_RD_Num.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 84);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 12);
            this.label24.TabIndex = 43;
            this.label24.Text = "读数据次数：";
            // 
            // textBox_RI_UnhitRate
            // 
            this.textBox_RI_UnhitRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RI_UnhitRate.Location = new System.Drawing.Point(343, 41);
            this.textBox_RI_UnhitRate.Name = "textBox_RI_UnhitRate";
            this.textBox_RI_UnhitRate.ReadOnly = true;
            this.textBox_RI_UnhitRate.Size = new System.Drawing.Size(58, 14);
            this.textBox_RI_UnhitRate.TabIndex = 42;
            this.textBox_RI_UnhitRate.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 41;
            this.label19.Text = "不命中率：";
            // 
            // textBox_RI_Unhit
            // 
            this.textBox_RI_Unhit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RI_Unhit.Location = new System.Drawing.Point(221, 41);
            this.textBox_RI_Unhit.Name = "textBox_RI_Unhit";
            this.textBox_RI_Unhit.ReadOnly = true;
            this.textBox_RI_Unhit.Size = new System.Drawing.Size(58, 14);
            this.textBox_RI_Unhit.TabIndex = 40;
            this.textBox_RI_Unhit.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(138, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 39;
            this.label20.Text = "不命中次数：";
            // 
            // textBox_RI_Num
            // 
            this.textBox_RI_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RI_Num.Location = new System.Drawing.Point(93, 39);
            this.textBox_RI_Num.Name = "textBox_RI_Num";
            this.textBox_RI_Num.ReadOnly = true;
            this.textBox_RI_Num.Size = new System.Drawing.Size(58, 14);
            this.textBox_RI_Num.TabIndex = 38;
            this.textBox_RI_Num.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 12);
            this.label21.TabIndex = 37;
            this.label21.Text = "读指令次数：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(396, 10);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 39;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(374, 444);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(65, 12);
            this.label29.TabIndex = 40;
            this.label29.Text = "当前指令：";
            // 
            // Curr_Instruct
            // 
            this.Curr_Instruct.Location = new System.Drawing.Point(410, 475);
            this.Curr_Instruct.Name = "Curr_Instruct";
            this.Curr_Instruct.Size = new System.Drawing.Size(248, 21);
            this.Curr_Instruct.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(374, 527);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(65, 12);
            this.label28.TabIndex = 19;
            this.label28.Text = "访问类型：";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(445, 527);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(58, 14);
            this.textBox1.TabIndex = 55;
            this.textBox1.Text = "NULL";
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(585, 527);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(58, 14);
            this.textBox15.TabIndex = 57;
            this.textBox15.Text = "NULL";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(514, 527);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 12);
            this.label30.TabIndex = 56;
            this.label30.Text = "访问地址：";
            // 
            // textBox_Block_Num
            // 
            this.textBox_Block_Num.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Block_Num.Location = new System.Drawing.Point(444, 562);
            this.textBox_Block_Num.Name = "textBox_Block_Num";
            this.textBox_Block_Num.ReadOnly = true;
            this.textBox_Block_Num.Size = new System.Drawing.Size(58, 14);
            this.textBox_Block_Num.TabIndex = 59;
            this.textBox_Block_Num.Text = "NULL";
            this.textBox_Block_Num.TextChanged += new System.EventHandler(this.textBox_Block_Num_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(373, 562);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 12);
            this.label31.TabIndex = 58;
            this.label31.Text = "块号：";
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Location = new System.Drawing.Point(585, 561);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(58, 14);
            this.textBox17.TabIndex = 61;
            this.textBox17.Text = "NULL";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(514, 561);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(65, 12);
            this.label32.TabIndex = 60;
            this.label32.Text = "命中情况：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 635);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBox_Block_Num);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.Curr_Instruct);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox_Total_UnhitRate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_Total_Unhit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox_Total_Num);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbBox_Unhit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbBox_Write);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbBox_Pre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBox_Replace);
            this.Controls.Add(this.cbBox_Link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBox_Block);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cache模拟器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBox_Block;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBox_Link;
        private System.Windows.Forms.ComboBox cbBox_Replace;
        private System.Windows.Forms.ComboBox cbBox_Pre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBox_Write;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBox_Unhit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbBox_Totle;
        private System.Windows.Forms.ComboBox cbBox_Instruct;
        private System.Windows.Forms.ComboBox cbBox_Data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_addr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button FULL;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbBox_Visit;
        private System.Windows.Forms.Button Hand;
        private System.Windows.Forms.TextBox Hand_Addr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_Total_Num;
        private System.Windows.Forms.TextBox textBox_Total_Unhit;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_Total_UnhitRate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_WD_UnhitRate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox_WD_Unhit;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_WD_Num;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_RD_UnhitRate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_RD_Unhit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox_RD_Num;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox_RI_UnhitRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_RI_Unhit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_RI_Num;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox Curr_Instruct;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox_Block_Num;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label32;
    }
}

