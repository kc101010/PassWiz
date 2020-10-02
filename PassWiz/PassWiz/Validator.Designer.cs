namespace PassWiz
{
    partial class Validator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validator));
            this.Title = new System.Windows.Forms.Label();
            this.input_valPassw = new System.Windows.Forms.TextBox();
            this.cmd_validate = new System.Windows.Forms.Button();
            this.output_Results = new System.Windows.Forms.Label();
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
            this.Title.TabIndex = 10;
            this.Title.Text = "PassWiz";
            // 
            // input_valPassw
            // 
            this.input_valPassw.Location = new System.Drawing.Point(213, 108);
            this.input_valPassw.Margin = new System.Windows.Forms.Padding(2);
            this.input_valPassw.Name = "input_valPassw";
            this.input_valPassw.Size = new System.Drawing.Size(168, 20);
            this.input_valPassw.TabIndex = 11;
            // 
            // cmd_validate
            // 
            this.cmd_validate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_validate.Location = new System.Drawing.Point(251, 246);
            this.cmd_validate.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_validate.Name = "cmd_validate";
            this.cmd_validate.Size = new System.Drawing.Size(94, 40);
            this.cmd_validate.TabIndex = 12;
            this.cmd_validate.Text = "Validate";
            this.cmd_validate.UseVisualStyleBackColor = true;
            this.cmd_validate.Click += new System.EventHandler(this.cmd_validate_Click);
            // 
            // output_Results
            // 
            this.output_Results.AutoSize = true;
            this.output_Results.Location = new System.Drawing.Point(225, 184);
            this.output_Results.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output_Results.Name = "output_Results";
            this.output_Results.Size = new System.Drawing.Size(149, 13);
            this.output_Results.TabIndex = 13;
            this.output_Results.Text = "PROGRAM NOT EXECUTED";
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.output_Results);
            this.Controls.Add(this.cmd_validate);
            this.Controls.Add(this.input_valPassw);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Validator";
            this.Text = "PassWiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox input_valPassw;
        private System.Windows.Forms.Button cmd_validate;
        private System.Windows.Forms.Label output_Results;
    }
}