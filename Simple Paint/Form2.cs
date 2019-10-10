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
            if(cond == 0)
            {
                lblSure.Text = "Please enter Yes or No";
                return;
            }
            SPaint.drwClear = cond == 1 ? true : false;
            this.Close();
            lblSure.Text = "Are you sure?";
            txtYesNo.Text = "";
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SPaint.drwClear = false;
            this.Close();
        }

        private void TxtYesNo_TextChanged(object sender, EventArgs e)
        {
            switch (txtYesNo.Text)
            {
                case "Yes":
                    cond = 1;
                    break;
                case "No":
                    cond = 2;
                    break;
                default:
                    cond = 0;
                    break;
            }
        }
    }
}
