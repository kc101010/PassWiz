using System;
using System.Windows.Forms;
using System.Drawing;

//VALIDATOR FORM CODE

namespace PassWiz
{
    public partial class Validator : Form
    {
        public Validator()
        {
            InitializeComponent();

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

        private void cmd_validate_Click(object sender, EventArgs e)
        {
            //assign the storage object as the input text
            P_Val.PasswordToValidate = input_valPassw.Text;

            //Change the result label text based on the outcome
            output_Results.Text = P_Val.validatePassword();
            
        }
    }
}
  