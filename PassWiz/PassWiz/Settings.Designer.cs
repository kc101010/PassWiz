namespace PassWiz
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Title = new System.Windows.Forms.Label();
            this.lb_colorSch = new System.Windows.Forms.Label();
            this.sel_colorSch = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.ask_before_reset = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Title.Location = new System.Drawing.Point(247, 42);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(105, 29);
            this.Title.TabIndex = 12;
            this.Title.Text = "PassWiz";
            // 
            // lb_colorSch
            // 
            this.lb_colorSch.AutoSize = true;
            this.lb_colorSch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_colorSch.Location = new System.Drawing.Point(244, 120);
            this.lb_colorSch.Name = "lb_colorSch";
            this.lb_colorSch.Size = new System.Drawing.Size(108, 20);
            this.lb_colorSch.TabIndex = 13;
            this.lb_colorSch.Text = "Colour/Theme";
            // 
            // sel_colorSch
            // 
            this.sel_colorSch.AllowDrop = true;
            this.sel_colorSch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sel_colorSch.FormattingEnabled = true;
            this.sel_colorSch.Items.AddRange(new object[] {
            "Standard",
            "Light",
            "Dark",
            "Blue"});
            this.sel_colorSch.Location = new System.Drawing.Point(231, 143);
            this.sel_colorSch.Name = "sel_colorSch";
            this.sel_colorSch.Size = new System.Drawing.Size(133, 21);
            this.sel_colorSch.TabIndex = 14;
            this.sel_colorSch.SelectedIndexChanged += new System.EventHandler(this.sel_colorSch_SelectedIndexChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.Location = new System.Drawing.Point(231, 192);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(133, 43);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "RESET SETTINGS";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveSettings.Location = new System.Drawing.Point(231, 256);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(133, 43);
            this.btn_saveSettings.TabIndex = 16;
            this.btn_saveSettings.Text = "SAVE";
            this.btn_saveSettings.UseVisualStyleBackColor = true;
            this.btn_saveSettings.Click += new System.EventHandler(this.btn_saveSettings_Click);
            // 
            // ask_before_reset
            // 
            this.ask_before_reset.AutoSize = true;
            this.ask_before_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ask_before_reset.Location = new System.Drawing.Point(371, 203);
            this.ask_before_reset.Name = "ask_before_reset";
            this.ask_before_reset.Size = new System.Drawing.Size(137, 17);
            this.ask_before_reset.TabIndex = 17;
            this.ask_before_reset.Text = "Ask me before resetting";
            this.ask_before_reset.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ask_before_reset);
            this.Controls.Add(this.btn_saveSettings);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.sel_colorSch);
            this.Controls.Add(this.lb_colorSch);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lb_colorSch;
        private System.Windows.Forms.ComboBox sel_colorSch;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_saveSettings;
        private System.Windows.Forms.CheckBox ask_before_reset;
    }
}