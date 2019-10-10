using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Paint
{
    public partial class ClearScreen : Form
    {
        int cond;
        public ClearScreen()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            CheckForConfirmation();

        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CheckForConfirmation();

        }

        private void TxtYesNo_TextChanged(object sender, EventArgs e)
        {
            switch (txtYesNo.Text.ToLower())                            //checks the input if it matches
            {
                case "yes":
                    cond = 1;
                    break;
                case "no":
                    cond = 2;
                    break;
                default:
                    cond = 0;
                    break;
            }
        }
                                                                        //checks the input textbox for confirmation
        private void CheckForConfirmation()
        {
            if (cond == 0)                                              //checks the state of the switch, on 0 (not yes or no), ask again.
            {
                lblSure.Text = "Please enter Yes or No";
                return;
            }
            SPaint.drawClear = cond == 1 ? true : false;                //checks if cond is 1, if it is, SPaint.drawClear equals true. else false.
            this.Close();
            lblSure.Text = "Are you sure?";                             //resets the label and textbox.
            txtYesNo.Text = "";
        }
    }
}
