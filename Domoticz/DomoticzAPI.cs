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
        private DateTime gameStart;

        public DomoticzAPI(DateTime gameStart) 
        {
            this.gameStart = gameStart;
        }

        public void ToggleScene(int id)
        {
            string url = baseUrl + "json.htm?type=command&param=switchscene&idx=" + id.ToString() + "&switchcmd=Toggle";
            using (WebClient wc = new WebClient())
            {
                var jsonResponse = wc.DownloadString(url);
            }
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
                            List<string> msgList = logItem.GetValue("message").ToString().Split(null).ToList();
                            DateTime timeStamp = Convert.ToDateTime(msgList[0] + " " + msgList[1]);
                            msgList.RemoveAt(0);
                            msgList.RemoveAt(2);
                            msgList.RemoveAt(3);
                            msgList.RemoveAt(1);
                            string msg = "";
                            foreach (string item in msgList)
                            {
                                msg += item + " ";
                            }
                            if (timeStamp > gameStart)
                            {
                                logs.Add(msg);
                            }
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
