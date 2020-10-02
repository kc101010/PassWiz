using System;
using System.Windows.Forms;
using System.Drawing;

//      GENERATOR FORM CODE

namespace PassWiz
{
    public partial class Generator : Form
    {
        public Generator()
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


        //Call when generate password button clicked
        public void cmd_GenPassword_Click(object sender, EventArgs e)
        {
            //Assign generator length & amount as values from interface
            P_Generator.length = (int)uinput_Length.Value;
            int amount = (int)uinput_Amount.Value;

            //Some input validation to ensure blank passwords aren't displayed
            if (P_Generator.length <= 0 || amount <= 0) {
                MessageBox.Show("Amount/Length cannot be 0 - please try again");
            }
             
            //Call the generator for the input of amount
            for (int m = 0; m < amount; m++) {
                disp_pass.Items.Add(P_Generator.passwordBuilder(P_Generator.length));
            }
        }

        //Clear listbox
        private void cmd_clearList_Click(object sender, EventArgs e)
        {
            disp_pass.Items.Clear();
        }
    }
}
