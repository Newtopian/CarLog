using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarLog
{
    class GasEventListViewModel
    {
        private readonly List<GasFillEvent> _gasFillEventList = new List<GasFillEvent>();

        public IEnumerable<GasFillEvent> EventList => _gasFillEventList;

        public void AddGasFillEvent(GasFillEvent gasEvent)
        {
            _gasFillEventList.Add(gasEvent);
        }
    }
}
