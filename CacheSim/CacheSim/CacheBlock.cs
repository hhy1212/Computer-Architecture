using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheSim
{
    internal class CacheBlockStruct 
    {
        public uint tag { get; set; }
        public uint flag { get; set; } //time
    }
}
