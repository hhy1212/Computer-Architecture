using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheSim
{
    class Result
    {
        public int total_Num { get; set; }
        public int total_Unhit { get; set; }
        public double total_UnhitRate { get; set; }
        public int writeD_Num { get; set; } 
        public int writeD_Unhit { get; set; } 
        public double writeD_UnhitRate { get; set; }
        public int readD_Num { get; set; } 
        public int readD_Unhit { get; set; } 
        public double readD_UnhitRate { get; set; } 
        public int readI_Num { get; set; }
        public int readI_Unhit { get; set; } 
        public double readI_UnhitRate { get; set; } 
        public string curr_Instruct { get; set; } 
        public string type { get; set; } 
        public int address { get; set; }
        public uint block_Num { get; set; } 
        public bool hit { get; set; } 
    }
}
