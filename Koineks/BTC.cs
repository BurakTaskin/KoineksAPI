using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koineks
{
    public class BTC
    {
        public string short_code;
        public string name;
        public string currency;
        public string current;
        public string change_amount;
        public string change_percentage;
        public string high;
        public string low;
        public string volume;
        public string ask;
        public string bid;
        public long timestamp;  
        public string Short_code { get => short_code; set => short_code = value; }
        public string Name { get => name; set => name = value; }
        public string Currency { get => currency; set => currency = value; }
        public string Current { get => current; set => current = value; }
        public string Change_amount { get => change_amount; set => change_amount = value; }
        public string Change_percentage { get => change_percentage; set => change_percentage = value; }
        public string High { get => high; set => high = value; }
        public string Low { get => low; set => low = value; }
        public string Volume { get => volume; set => volume = value; }
        public string Ask { get => ask; set => ask = value; }
        public string Bid { get => bid; set => bid = value; }
        public long Timestamp { get => timestamp; set => timestamp = value; }
    }
}