using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koineks
{
    public class BtcCollection
    {
        private List<BTC> bitcoins;

        public List<BTC> Bitcoins { get => bitcoins; set => bitcoins = value; }
    }
}