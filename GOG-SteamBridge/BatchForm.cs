using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace GOG_SteamBridge
{
    public partial class BatchForm : Form
    {
        public BatchForm()
        {
            InitializeComponent();
            batchProcess_folderBrowserDialog.Description = "Choose the folder in which GOG.com game shortcut files (*.lnk) have been placed";
        }

        private void button1_Click(object sender, EventArgs e){

            batchProcess_folderBrowserDialog.ShowDialog();
            batchFileTextbox.Text = batchProcess_folderBrowserDialog.SelectedPath;
            if (batchProcess_folderBrowserDialog.SelectedPath != "") { processBtn.Enabled = true; }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to create a wrappers for each GOG.com game shortcut in " + Environment.NewLine + batchProcess_folderBrowserDialog.SelectedPath + " ?";
            DialogResult result = MessageBox.Show(message, "Confirm wrapper creation", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            label1.Text = "Generating wrappers, please allow Windows to run batchcompile.exe";
            string [] fileEntries = Directory.GetFiles(batchProcess_folderBrowserDialog.SelectedPath);
            int i = 0;
            foreach(string filenames in fileEntries)
            {
               
                if(!filenames.EndsWith(".lnk",true,null)){
                    continue;
                }
                WshShell shell = new WshShell();
                WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(filenames);
                String iconPath;
                if (shortcut.WorkingDirectory.Contains("ScummVM"))
                {
                    iconPath = Regex.Replace(shortcut.WorkingDirectory, "(?i)ScummVM", "gfw_high.ico");
                }
                else
                {
                    
                    iconPath = Regex.Replace(shortcut.WorkingDirectory, "(?i)DOSBOX", "gfw_high.ico");
                }

                if (!System.IO.File.Exists(iconPath)){
                    continue;
                }

                Creation.createWrapper(filenames, Path.GetFileName(filenames), iconPath);
                System.IO.File.Copy(Application.StartupPath+@"\wrapper.exe",batchProcess_folderBrowserDialog.SelectedPath+@"\"+Path.GetFileNameWithoutExtension(filenames)+".exe");
                Creation.cleanup();
                i++;

            }
            MessageBox.Show("Processed "+i+" files in folder"+Environment.NewLine+batchProcess_folderBrowserDialog.SelectedPath);
            Process.Start("explorer.exe",batchProcess_folderBrowserDialog.SelectedPath);
            Application.Exit();
        }


    }
}
