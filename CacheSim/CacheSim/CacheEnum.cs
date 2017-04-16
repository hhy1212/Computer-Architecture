using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheSim
{
    internal enum CacheReplace
    {
        RAND,
        FIFO,
        LRU,
    }
    internal enum CacheNotHit
    {
        WriteAlloc,
        NotWriteAlloc,
    }
    internal enum Operator
    {
        RI,
        RD,
        WD,
    }
}
