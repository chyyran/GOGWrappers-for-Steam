using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace GOG_SteamBridge
{
    class Creation
    {
        private static string startupPath = AppDomain.CurrentDomain.BaseDirectory;
        public static void createWrapper(string shortcutPath, string safeFileName, string iconPath)
        {
            String gameName = safeFileName.Replace("Launch ", "");
            gameName = gameName.Replace(".lnk", "");
            System.IO.File.Copy(shortcutPath, startupPath + @"\"+gameName+".lnk",true);
            System.IO.File.Copy(iconPath, startupPath + @"\icon.ico",true);
            generateBatTemplate(gameName+".lnk");
            ProcessStartInfo compiler = new ProcessStartInfo(startupPath + @"\batchcompile.exe", "-bat launcher.bat -save wrapper.exe -icon icon.ico -invisible -temp -include "+"\"" +gameName+".lnk"+"\""+ "-description " + "\"GOGWizard Generated Wrapper for " + gameName + "\"");
            compiler.WindowStyle = ProcessWindowStyle.Hidden;

            Process.Start(compiler).WaitForExit();
        }

        private static void generateBatTemplate(string launchershortcut)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("@echo off");
            builder.AppendLine("\""+launchershortcut+"\"");
            System.IO.File.WriteAllText(startupPath + @"\launcher.bat", builder.ToString());

        }

        public static void cleanup(string gameName)
        {
            System.IO.File.Delete(startupPath + @"\icon.ico");
            System.IO.File.Delete(startupPath + @"\" + gameName);
            System.IO.File.Delete(startupPath + @"\wrapper.exe");
            System.IO.File.Delete(startupPath + @"\launcher.bat");
            System.IO.File.Delete(startupPath + @"\temp.lnk");

        }
    }
}
