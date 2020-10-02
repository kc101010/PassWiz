using System;
using System.Windows.Forms;
using System.Drawing;

namespace PassWiz
{
    public partial class HelpPage : Form
    {
        public HelpPage()
        {
            InitializeComponent();

            //Set background based on user settings
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

        //Clicking link opens support email
        private void contact_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:kcTranslationServices@gmx.com");
        }
    }
}
