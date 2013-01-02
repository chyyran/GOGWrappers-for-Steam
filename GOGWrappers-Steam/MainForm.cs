using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;



namespace GOG_SteamBridge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            chooseShortcut_openFileDialog.Title = "Choose GOG.com game shortcut";
            chooseShortcut_openFileDialog.CheckFileExists = true;
            chooseShortcut_openFileDialog.CheckFileExists = true;
            chooseShortcut_openFileDialog.Multiselect = false;
            chooseShortcut_openFileDialog.Filter = "Shortcut files (*.lnk)|*.LNK";

            chooseIcon_openFileDialog.Title = "Choose GOG.com game icon";
            chooseIcon_openFileDialog.CheckFileExists = true;
            chooseIcon_openFileDialog.CheckFileExists = true;
            chooseIcon_openFileDialog.Multiselect = false;
            chooseIcon_openFileDialog.Filter = "Icon files (*.ico)|*.ICO";

            saveWrapperDialog.Title = "Choose where to save the wrapper";
            saveWrapperDialog.Filter = "Applications (*.exe)|*.EXE";
            saveWrapperDialog.AddExtension = true;

        }

        #region Selection
        private void button1_Click(object sender, EventArgs e)
        {
            chooseShortcut_openFileDialog.ShowDialog();

        }


        private void chooseShortcut_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            if (System.IO.File.Exists(gogIconPath))
            {
                shortcutTextBox.Text = chooseShortcut_openFileDialog.FileName;
                chooseIcon_openFileDialog.FileName = gogIconPath;
                iconTextBox.Text = gogIconPath;
                chooseIconButton.Enabled = true;
                createWrapperButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("This is not a shortcut to a valid GOG DOSBOX or ScummVM game");
                chooseShortcut_openFileDialog.FileName = shortcutTextBox.Text;
                return;
            }
        }


        private string gogIconPath
        {
            get
            {
                WshShell shell = new WshShell();
                WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(chooseShortcut_openFileDialog.FileName);
                String iconPath;
                if (shortcut.WorkingDirectory.Contains("ScummVM"))
                {
                    return iconPath = Regex.Replace(shortcut.WorkingDirectory, "(?i)ScummVM", "gfw_high.ico");
                }
                else
                {

                    return iconPath = Regex.Replace(shortcut.WorkingDirectory, "(?i)DOSBOX", "gfw_high.ico");
                }
            }

        }

        private void chooseIconButton_Click(object sender, EventArgs e)
        {
            chooseIcon_openFileDialog.ShowDialog();
        }

        private void chooseIcon_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            iconTextBox.Text = chooseIcon_openFileDialog.FileName;

        }


        #endregion

        #region Creation
        private void createWrapperButton_Click(object sender, EventArgs e)
        {
            String message = "Are you sure you want to create a wrapper for" + Environment.NewLine + chooseShortcut_openFileDialog.FileName + Environment.NewLine + "with the icon" + Environment.NewLine + chooseIcon_openFileDialog.FileName;
            DialogResult result = MessageBox.Show(message,"Confirm wrapper creation",MessageBoxButtons.YesNo);
            

            if (result != DialogResult.Yes)
            {
                return;
            }
            label1.Text = "Generating a wrapper, please allow Windows to run batchcompile.exe";
            chooseShortcutButton.Enabled = false;
            chooseIconButton.Enabled = false;
            createWrapperButton.Enabled = false;
            Creation.createWrapper(chooseShortcut_openFileDialog.FileName, chooseShortcut_openFileDialog.SafeFileName, chooseIcon_openFileDialog.FileName);
            String saveFileName = chooseShortcut_openFileDialog.SafeFileName.Replace(".lnk", ".exe");
            saveWrapperDialog.FileName = saveFileName;
            saveWrapperDialog.ShowDialog();
        }
            


        private void saveWrapperDialog_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.File.Copy(Application.StartupPath + @"\wrapper.exe", saveWrapperDialog.FileName);
            Creation.cleanup();
            this.Close();
        }

        private void batchModeBtn_Click(object sender, EventArgs e)
        {
            BatchForm batchForm = new BatchForm();
            batchForm.ShowDialog();
        }



    }
        #endregion

    }
    

