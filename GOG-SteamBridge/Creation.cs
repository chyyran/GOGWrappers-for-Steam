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
            System.IO.File.Copy(shortcutPath, startupPath + @"\launcher.lnk");
            System.IO.File.Copy(iconPath, startupPath + @"\icon.ico");
            generateBatTemplate();
            ProcessStartInfo compiler = new ProcessStartInfo(startupPath + @"\batchcompile.exe", "-bat launcher.bat -save wrapper.exe -icon icon.ico -invisible -temp -include launcher.lnk -description " + "\"GOGWizard Generated Wrapper for " + gameName + "\"");
            compiler.WindowStyle = ProcessWindowStyle.Hidden;

            Process.Start(compiler).WaitForExit();
        }

        private static void generateBatTemplate()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("@echo off");
            builder.AppendLine("launcher.lnk");
            System.IO.File.WriteAllText(startupPath + @"\launcher.bat", builder.ToString());

        }

        public static void cleanup()
        {
            System.IO.File.Delete(startupPath + @"\icon.ico");
            System.IO.File.Delete(startupPath + @"\launcher.lnk");
            System.IO.File.Delete(startupPath + @"\wrapper.exe");
            System.IO.File.Delete(startupPath + @"\launcher.bat");

        }
    }
}
