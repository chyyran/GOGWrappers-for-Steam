using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using Shell32;



namespace GOG_SteamBridge
{
    public partial class MainForm : Form
    {
        String shortcutTempPath = Application.StartupPath + @"\temp.lnk";
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
            saveWrapperDialog.Filter = "Applications (*.exe)|*.exe";
            saveWrapperDialog.AddExtension = true;
            

        }

        #region Selection
        private void button1_Click(object sender, EventArgs e)
        {
            chooseShortcut_openFileDialog.ShowDialog();

        }


        private void chooseShortcut_openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.Copy(chooseShortcut_openFileDialog.FileName, shortcutTempPath, true);
            
            if (Path.GetFileName(gogIconPath) == "gfw_high.ico")
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
                var shl = new Shell32.Shell();         // Move this to class scope
                var dir = shl.NameSpace(System.IO.Path.GetDirectoryName(shortcutTempPath));
                var itm = dir.Items().Item(System.IO.Path.GetFileName(shortcutTempPath));
                var lnk = (Shell32.ShellLinkObject)itm.GetLink;
                //lnk.GetIconLocation(out strIcon);
                String strIcon;
                lnk.GetIconLocation(out strIcon);
                return strIcon;
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
            label1.Text = "Generating a wrapper";
            chooseShortcutButton.Enabled = false;
            chooseIconButton.Enabled = false;
            createWrapperButton.Enabled = false;
            Creation.createWrapper(chooseShortcut_openFileDialog.FileName, chooseShortcut_openFileDialog.SafeFileName, chooseIcon_openFileDialog.FileName);
            String saveFileName = chooseShortcut_openFileDialog.SafeFileName.Replace(".lnk", ".exe");
            saveWrapperDialog.FileName = saveFileName;
            saveWrapperDialog.ShowDialog();
            Creation.cleanup(chooseShortcut_openFileDialog.SafeFileName);
            this.Close();
            
        }
            


        private void saveWrapperDialog_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.File.Copy(Application.StartupPath + @"\wrapper.exe", saveWrapperDialog.FileName,true);
        }

        private void batchModeBtn_Click(object sender, EventArgs e)
        {
            BatchForm batchForm = new BatchForm();
            batchForm.ShowDialog();
        }


    }
        #endregion



    }
    

