
using System;
using System.Drawing;
using System.Windows.Forms;


namespace PassWiz
{
    public partial class passwiz_form : Form
    {
        public passwiz_form()
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


        private void passwiz_form_Load(object sender, EventArgs e)
        {
           
        }

        //Click button to open password generator interface
        private void cmd_openPGen_Click(object sender, EventArgs e)
        {
            //Call a new generator window - show dialog allows user to easily return to the menu
            new Generator().ShowDialog();
            
        }

        //Click button to open password validator interface
        private void cmd_openPVal_Click(object sender, EventArgs e)
        {
            //Call a new validator window - show dialog allows user to easily return to the menu
            new Validator().ShowDialog();
            
        }

        //Click button to open help interface
        private void cmd_openHelp_Click(object sender, EventArgs e) 
        {
            //Call new Help page window
            new HelpPage().ShowDialog();
        }

        //Click button to open settings interface
        private void cmd_openSettings_Click(object sender, EventArgs e) 
        {
            //call new settings window
            new Settings().ShowDialog();
        }

       
    }
}
