using System;
using System.Windows.Forms;
using System.Drawing;

namespace PassWiz
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            //Allow user to use save button
            btn_saveSettings.Enabled = true;

            //load user settings 
            ask_before_reset.Checked = Properties.Settings.Default.AskBeforeReset;
            sel_colorSch.Text = Properties.Settings.Default.Colour;

            //background setter
            switch (Properties.Settings.Default.Colour)
            {
                case "Standard":
                    this.BackColor = Color.LightGray;
                    break;

                case "Light":
                    this.BackColor = Color.WhiteSmoke;
                    break;

                case "Dark":
                    this.BackColor = Color.DarkGray;
                    break;

                case "Blue":
                    this.BackColor = Color.Blue;
                    break;

                default:
                    this.BackColor = DefaultBackColor;
                    break;
            }

        }

        private void ask_before_reset_Changed(object sender, EventArgs e) {
            btn_saveSettings.Enabled = true;
      
        }

        

        private void btn_saveSettings_Click(object sender, EventArgs e)
        {
            //assigns and saves settings
            Properties.Settings.Default.AskBeforeReset = ask_before_reset.Checked;
            Properties.Settings.Default.Colour = sel_colorSch.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            MessageBox.Show("Saved Settings. Please restart for changes to take effect.");
            btn_saveSettings.Enabled = false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //Declare var to store users choice
            DialogResult user;

            //execute if user wishes to be asked
            if (Properties.Settings.Default.AskBeforeReset)
            {
                //ask user if they wish to reset
                user = MessageBox.Show("Are you sure you want to reset your settings?", "Sure?", MessageBoxButtons.YesNo);
                
                //if they confirm, reset settings and close
                if (user == System.Windows.Forms.DialogResult.Yes) {
                    Properties.Settings.Default.Reset();
                    Properties.Settings.Default.Save();
                    this.Close();
                }
          
            }
            else //do the same but not so complicated
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                this.Close();
            }

        }

        private void sel_colorSch_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_saveSettings.Enabled = true;
        }
    }
}
