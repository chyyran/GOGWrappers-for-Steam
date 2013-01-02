namespace GOG_SteamBridge
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.chooseShortcut_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseShortcutButton = new System.Windows.Forms.Button();
            this.shortcutTextBox = new System.Windows.Forms.TextBox();
            this.chooseIconButton = new System.Windows.Forms.Button();
            this.iconTextBox = new System.Windows.Forms.TextBox();
            this.chooseIcon_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.createWrapperButton = new System.Windows.Forms.Button();
            this.saveWrapperDialog = new System.Windows.Forms.SaveFileDialog();
            this.batchModeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOGWrappers for Steam - GOG.com DOSBOX and ScummVM Wrapper Creation Wizard for St" +
                "eam";
            // 
            // chooseShortcut_openFileDialog
            // 
            this.chooseShortcut_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.chooseShortcut_openFileDialog_FileOk);
            // 
            // chooseShortcutButton
            // 
            this.chooseShortcutButton.Location = new System.Drawing.Point(352, 37);
            this.chooseShortcutButton.Name = "chooseShortcutButton";
            this.chooseShortcutButton.Size = new System.Drawing.Size(307, 23);
            this.chooseShortcutButton.TabIndex = 1;
            this.chooseShortcutButton.Text = "Choose Shortcut";
            this.chooseShortcutButton.UseVisualStyleBackColor = true;
            this.chooseShortcutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // shortcutTextBox
            // 
            this.shortcutTextBox.Location = new System.Drawing.Point(13, 39);
            this.shortcutTextBox.Name = "shortcutTextBox";
            this.shortcutTextBox.ReadOnly = true;
            this.shortcutTextBox.Size = new System.Drawing.Size(307, 20);
            this.shortcutTextBox.TabIndex = 2;
            // 
            // chooseIconButton
            // 
            this.chooseIconButton.Enabled = false;
            this.chooseIconButton.Location = new System.Drawing.Point(352, 63);
            this.chooseIconButton.Name = "chooseIconButton";
            this.chooseIconButton.Size = new System.Drawing.Size(307, 23);
            this.chooseIconButton.TabIndex = 3;
            this.chooseIconButton.Text = "Choose Icon";
            this.chooseIconButton.UseVisualStyleBackColor = true;
            this.chooseIconButton.Click += new System.EventHandler(this.chooseIconButton_Click);
            // 
            // iconTextBox
            // 
            this.iconTextBox.Location = new System.Drawing.Point(13, 66);
            this.iconTextBox.Name = "iconTextBox";
            this.iconTextBox.ReadOnly = true;
            this.iconTextBox.Size = new System.Drawing.Size(307, 20);
            this.iconTextBox.TabIndex = 4;
            // 
            // chooseIcon_openFileDialog
            // 
            this.chooseIcon_openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.chooseIcon_openFileDialog_FileOk);
            // 
            // createWrapperButton
            // 
            this.createWrapperButton.Enabled = false;
            this.createWrapperButton.Location = new System.Drawing.Point(14, 99);
            this.createWrapperButton.Name = "createWrapperButton";
            this.createWrapperButton.Size = new System.Drawing.Size(645, 47);
            this.createWrapperButton.TabIndex = 5;
            this.createWrapperButton.Text = "Create Wrapper";
            this.createWrapperButton.UseVisualStyleBackColor = true;
            this.createWrapperButton.Click += new System.EventHandler(this.createWrapperButton_Click);
            // 
            // saveWrapperDialog
            // 
            this.saveWrapperDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveWrapperDialog_FileOk);
            // 
            // batchModeBtn
            // 
            this.batchModeBtn.Location = new System.Drawing.Point(14, 152);
            this.batchModeBtn.Name = "batchModeBtn";
            this.batchModeBtn.Size = new System.Drawing.Size(645, 29);
            this.batchModeBtn.TabIndex = 6;
            this.batchModeBtn.Text = "Batch Mode";
            this.batchModeBtn.UseVisualStyleBackColor = true;
            this.batchModeBtn.Click += new System.EventHandler(this.batchModeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 185);
            this.Controls.Add(this.batchModeBtn);
            this.Controls.Add(this.createWrapperButton);
            this.Controls.Add(this.iconTextBox);
            this.Controls.Add(this.chooseIconButton);
            this.Controls.Add(this.shortcutTextBox);
            this.Controls.Add(this.chooseShortcutButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOGWrappers for Steam 1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog chooseShortcut_openFileDialog;
        private System.Windows.Forms.Button chooseShortcutButton;
        private System.Windows.Forms.TextBox shortcutTextBox;
        private System.Windows.Forms.Button chooseIconButton;
        private System.Windows.Forms.TextBox iconTextBox;
        private System.Windows.Forms.OpenFileDialog chooseIcon_openFileDialog;
        private System.Windows.Forms.Button createWrapperButton;
        private System.Windows.Forms.SaveFileDialog saveWrapperDialog;
        private System.Windows.Forms.Button batchModeBtn;
    }
}

