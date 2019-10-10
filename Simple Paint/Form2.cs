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
        public ClearScreen()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            SPaint.drwClear = true;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SPaint.drwClear = false;
            this.Close();
        }
    }
}
