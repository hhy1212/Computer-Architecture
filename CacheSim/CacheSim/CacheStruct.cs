using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheSim
{
    internal class CacheStruct
    {
        public uint Usize { get; set; }
        public uint Dsize { get; set; }
        public uint Isize { get; set; }
        public uint blockSize { get; set; }
        public uint assoc { get; set; }
        public CacheReplace replace { get; set; }
        public CacheNotHit unHit { get; set; }

    }
}
