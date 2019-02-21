using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Koineks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {

                string RawJson = client.DownloadString("https://koineks.com/ticker");
                Label3.Text = RawJson;
       
                RawJson = RawJson.Substring(RawJson.IndexOf('{', 2)); //baştaki 7 karakterlik kısmı kaldırır.
                string BtcPparca = RawJson.Substring(0, RawJson.IndexOf('}')+1);
                BTC BtcCollection = JsonConvert.DeserializeObject<BTC>(BtcPparca);


                RawJson = RawJson.Substring(BtcPparca.Length);
                RawJson = RawJson.Substring(RawJson.IndexOf('{', 2)); //baştaki 7 karakterlik kısmı kaldırır.
                string Ethparca = RawJson.Substring(0, RawJson.IndexOf('}') + 1);
                ETH EthCollection = JsonConvert.DeserializeObject<ETH>(Ethparca);




                Label3.Text = "BTC para birimi:"+BtcCollection.current;
                Label4.Text = "Etc para birimi:"+EthCollection.current;


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}