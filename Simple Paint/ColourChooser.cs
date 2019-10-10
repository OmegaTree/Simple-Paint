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
    public partial class ColourChooser : Form
    {
        public ColourChooser()
        {
            InitializeComponent();
        }

        private void ColourChooser_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Black;
        }

        private void ClrBlue_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Blue;
        }

        private void ClrRed_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Red;
        }

        private void ClrGreen_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Green;
        }

        private void ClrCyan_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Cyan;
        }

        private void ClrMagenta_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Magenta;
        }

        private void ClrYellow_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Yellow;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ereaser_Click(object sender, EventArgs e)
        {
            SPaint.clrChosen = Color.Transparent;
        }
    }
}
