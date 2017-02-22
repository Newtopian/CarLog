using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLog
{
    class GasFillEvent
    {
        public int TotalPrice { get; private set; }
        public int TotalLiters { get; private set; }
        public DateTime Timestamp { get; private set; }
    }
}
