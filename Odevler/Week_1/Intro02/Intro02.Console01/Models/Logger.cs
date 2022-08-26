using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02.Console01.Models
{
  public  class Logger
    {
        public void LogFile(string path,string log)
        {
            File.WriteAllText(path,log);
        
        }

        public string  BuildLog(string info)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Tarih: ");
            sb.AppendLine();
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            sb.Append("Info : ").Append(info);
            return sb.ToString();
        }

    }
}
