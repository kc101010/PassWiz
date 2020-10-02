namespace PassWiz
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.Title = new System.Windows.Forms.Label();
            this.cmd_GenPassword = new System.Windows.Forms.Button();
            this.uinput_Length = new System.Windows.Forms.NumericUpDown();
            this.disp_pass = new System.Windows.Forms.ListBox();
            this.uinput_Amount = new System.Windows.Forms.NumericUpDown();
            this.label_length = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.cmd_clearList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uinput_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uinput_Amount)).BeginInit();
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
            this.Title.TabIndex = 9;
            this.Title.Text = "PassWiz";
            // 
            // cmd_GenPassword
            // 
            this.cmd_GenPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_GenPassword.Location = new System.Drawing.Point(225, 274);
            this.cmd_GenPassword.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_GenPassword.Name = "cmd_GenPassword";
            this.cmd_GenPassword.Size = new System.Drawing.Size(173, 72);
            this.cmd_GenPassword.TabIndex = 10;
            this.cmd_GenPassword.Text = "Generate";
            this.cmd_GenPassword.UseVisualStyleBackColor = true;
            this.cmd_GenPassword.Click += new System.EventHandler(this.cmd_GenPassword_Click);
            // 
            // uinput_Length
            // 
            this.uinput_Length.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uinput_Length.Location = new System.Drawing.Point(154, 284);
            this.uinput_Length.Margin = new System.Windows.Forms.Padding(2);
            this.uinput_Length.Name = "uinput_Length";
            this.uinput_Length.Size = new System.Drawing.Size(45, 20);
            this.uinput_Length.TabIndex = 12;
            // 
            // disp_pass
            // 
            this.disp_pass.FormattingEnabled = true;
            this.disp_pass.Location = new System.Drawing.Point(11, 80);
            this.disp_pass.Margin = new System.Windows.Forms.Padding(2);
            this.disp_pass.Name = "disp_pass";
            this.disp_pass.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.disp_pass.Size = new System.Drawing.Size(578, 186);
            this.disp_pass.TabIndex = 13;
            // 
            // uinput_Amount
            // 
            this.uinput_Amount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uinput_Amount.Location = new System.Drawing.Point(154, 314);
            this.uinput_Amount.Margin = new System.Windows.Forms.Padding(2);
            this.uinput_Amount.Name = "uinput_Amount";
            this.uinput_Amount.Size = new System.Drawing.Size(45, 20);
            this.uinput_Amount.TabIndex = 14;
            // 
            // label_length
            // 
            this.label_length.AutoSize = true;
            this.label_length.Location = new System.Drawing.Point(102, 288);
            this.label_length.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_length.Name = "label_length";
            this.label_length.Size = new System.Drawing.Size(40, 13);
            this.label_length.TabIndex = 15;
            this.label_length.Text = "Length";
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Location = new System.Drawing.Point(102, 318);
            this.label_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(43, 13);
            this.label_amount.TabIndex = 16;
            this.label_amount.Text = "Amount";
            // 
            // cmd_clearList
            // 
            this.cmd_clearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_clearList.Location = new System.Drawing.Point(403, 291);
            this.cmd_clearList.Name = "cmd_clearList";
            this.cmd_clearList.Size = new System.Drawing.Size(73, 38);
            this.cmd_clearList.TabIndex = 17;
            this.cmd_clearList.Text = "Clear";
            this.cmd_clearList.UseVisualStyleBackColor = true;
            this.cmd_clearList.Click += new System.EventHandler(this.cmd_clearList_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmd_clearList);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_length);
            this.Controls.Add(this.uinput_Amount);
            this.Controls.Add(this.disp_pass);
            this.Controls.Add(this.uinput_Length);
            this.Controls.Add(this.cmd_GenPassword);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Generator";
            this.Text = "PassWiz";
            ((System.ComponentModel.ISupportInitialize)(this.uinput_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uinput_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button cmd_GenPassword;
        private System.Windows.Forms.NumericUpDown uinput_Length;
        private System.Windows.Forms.ListBox disp_pass;
        private System.Windows.Forms.NumericUpDown uinput_Amount;
        private System.Windows.Forms.Label label_length;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Button cmd_clearList;
    }
}