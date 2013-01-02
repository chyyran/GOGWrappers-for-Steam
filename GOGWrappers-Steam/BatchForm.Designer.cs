namespace GOG_SteamBridge
{
    partial class BatchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.batchFileTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.batchProcess_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.processBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOGWrappers for Steam Batch Process - Process a folder of GOG.com DOSBOX and Scum" +
                "mVM Shortcuts";
            // 
            // batchFileTextbox
            // 
            this.batchFileTextbox.Location = new System.Drawing.Point(19, 44);
            this.batchFileTextbox.Name = "batchFileTextbox";
            this.batchFileTextbox.ReadOnly = true;
            this.batchFileTextbox.Size = new System.Drawing.Size(364, 20);
            this.batchFileTextbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose Shortcut Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // processBtn
            // 
            this.processBtn.Enabled = false;
            this.processBtn.Location = new System.Drawing.Point(19, 71);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(552, 47);
            this.processBtn.TabIndex = 3;
            this.processBtn.Text = "Process Folder";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(19, 124);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(552, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // BatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 159);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.batchFileTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOGWrappers for Steam 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox batchFileTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog batchProcess_folderBrowserDialog;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.Button backBtn;
    }
}