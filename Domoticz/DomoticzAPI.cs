using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace Verstoppertje_App.Domoticz
{
    class DomoticzAPI
    {
        private string baseUrl = "http://localhost:8080/";
        public List<string> logs = new List<string>();
        private string lastLogTime = "0";

        public DomoticzAPI(DateTime gameStart) 
        { 

        }

        public void GetLogs()
        {
            while (true)
            {
                string url = baseUrl + "json.htm?type=command&param=getlog&lastlogtime=" + lastLogTime + "&loglevel=1";
                using (WebClient wc = new WebClient())
                {
                    var jsonResponse = wc.DownloadString(url);
                    JObject json = JObject.Parse(jsonResponse);
                    List<string> logList = new List<string>();
                    foreach (JObject logItem in json.GetValue("result"))
                    {
                        if (!logs.Contains(logItem.GetValue("message").ToString()))
                        {
                            logs.Add(logItem.GetValue("message").ToString());
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
