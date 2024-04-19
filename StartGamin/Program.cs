
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StartGamin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo disInfo = new ProcessStartInfo();
            disInfo.WorkingDirectory = "C:/Users/matth/AppData/Local/Discord/app-1.0.9042";
            disInfo.FileName = "Discord.exe";

            ProcessStartInfo battleInfo = new ProcessStartInfo();
            battleInfo.WorkingDirectory = "C:/Program Files (x86)/Battle.net";
            battleInfo.FileName = "Battle.net Launcher";
            
            ProcessStartInfo xboxinfo = new ProcessStartInfo();
            xboxinfo.Arguments = "/c explorer.exe shell:appsFolder\\Microsoft.GamingApp_8wekyb3d8bbwe!Microsoft.Xbox.App";
            xboxinfo.WorkingDirectory = "C:/Users/matth";
            xboxinfo.FileName = "cmd.exe";

            ProcessStartInfo steamInfo = new ProcessStartInfo();
            steamInfo.WorkingDirectory = "C:/Program Files (x86)/Steam";
            steamInfo.FileName = "steam";





            Process.Start(disInfo);
            
            Process.Start(battleInfo);
            Process.Start(battleInfo);
            Process.Start(xboxinfo);
            Process.Start(steamInfo);
            Process.Start("chrome.exe");
      
            


        }
    }
}
