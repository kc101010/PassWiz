namespace PassWiz
{
    partial class passwiz_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwiz_form));
            this.cmd_openPGen = new System.Windows.Forms.Button();
            this.cmd_openPVal = new System.Windows.Forms.Button();
            this.cmd_openHelp = new System.Windows.Forms.Button();
            this.cmd_openSettings = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_openPGen
            // 
            this.cmd_openPGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_openPGen.Location = new System.Drawing.Point(218, 89);
            this.cmd_openPGen.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_openPGen.Name = "cmd_openPGen";
            this.cmd_openPGen.Size = new System.Drawing.Size(152, 79);
            this.cmd_openPGen.TabIndex = 0;
            this.cmd_openPGen.Text = "Password Generator";
            this.cmd_openPGen.UseVisualStyleBackColor = true;
            this.cmd_openPGen.Click += new System.EventHandler(this.cmd_openPGen_Click);
            // 
            // cmd_openPVal
            // 
            this.cmd_openPVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_openPVal.Location = new System.Drawing.Point(218, 173);
            this.cmd_openPVal.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_openPVal.Name = "cmd_openPVal";
            this.cmd_openPVal.Size = new System.Drawing.Size(152, 79);
            this.cmd_openPVal.TabIndex = 1;
            this.cmd_openPVal.Text = "Password Validator";
            this.cmd_openPVal.UseVisualStyleBackColor = true;
            this.cmd_openPVal.Click += new System.EventHandler(this.cmd_openPVal_Click);
            // 
            // cmd_openHelp
            // 
            this.cmd_openHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_openHelp.Location = new System.Drawing.Point(218, 257);
            this.cmd_openHelp.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_openHelp.Name = "cmd_openHelp";
            this.cmd_openHelp.Size = new System.Drawing.Size(70, 63);
            this.cmd_openHelp.TabIndex = 2;
            this.cmd_openHelp.Text = "?";
            this.cmd_openHelp.UseVisualStyleBackColor = true;
            this.cmd_openHelp.Click += new System.EventHandler(this.cmd_openHelp_Click);
            // 
            // cmd_openSettings
            // 
            this.cmd_openSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_openSettings.Location = new System.Drawing.Point(299, 257);
            this.cmd_openSettings.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_openSettings.Name = "cmd_openSettings";
            this.cmd_openSettings.Size = new System.Drawing.Size(70, 63);
            this.cmd_openSettings.TabIndex = 3;
            this.cmd_openSettings.Text = "SETTINGS";
            this.cmd_openSettings.UseVisualStyleBackColor = true;
            this.cmd_openSettings.Click += new System.EventHandler(this.cmd_openSettings_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Title.Location = new System.Drawing.Point(242, 41);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 29);
            this.Title.TabIndex = 4;
            this.Title.Text = "PassWiz";
            // 
            // passwiz_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.cmd_openSettings);
            this.Controls.Add(this.cmd_openHelp);
            this.Controls.Add(this.cmd_openPVal);
            this.Controls.Add(this.cmd_openPGen);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "passwiz_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassWiz";
            this.Load += new System.EventHandler(this.passwiz_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_openPGen;
        private System.Windows.Forms.Button cmd_openPVal;
        private System.Windows.Forms.Button cmd_openHelp;
        private System.Windows.Forms.Button cmd_openSettings;
        private System.Windows.Forms.Label Title;
    }
}

