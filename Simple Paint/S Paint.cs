using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Simple_Paint
{
    public partial class SPaint : Form
    {
        public SPaint()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Clock();
        }
        List<(int, int)> moves = new List<(int, int)>();
        bool drwLine;
        int drwX;
        int drwY;
        Timer tmr;
        int counter;
        Graphics g;
        public static bool drwClear;
        public static int pSize = 4;
        public static Color clrChosen = Color.Black;
        public static Pen p = new Pen(clrChosen, pSize);

        // Forms spawned through buttons.
        ColourChooser subPicker = new ColourChooser();
        ClearScreen subClear = new ClearScreen();

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drwLine = false;
        }
        private void Clock()
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            txtTimer.Text = DateTime.Now.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drwLine = true;
            drwX = e.X;
            drwY = e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Point point1 = new Point(drwX, drwY);
            Point point2 = new Point(e.X, e.Y);
            if (drwX < 200)
            {
                drwLine = false;
            }
            if (drwLine == true)
            {
                g.DrawLine(p, point1, point2);
                drwX = e.X;
                drwY = e.Y;
                moves.Add((drwX, drwY));
            }
            // Prints mouse coordinates
            int mseCoordinate = e.X - 200;
            MouseCoordinates.Text = mseCoordinate.ToString() + " , " + e.Y.ToString();
            counter++;
            lblCounter.Text = counter.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            subPicker.ShowDialog();
            p = new Pen(clrChosen, 4);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            subClear.ShowDialog();
            if (drwClear == true)
            {
                g.Clear(Color.White);
                drwClear = false;
            }
            drwClear = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReplay_Click(object sender, EventArgs e)
        {
            if (moves.Count < 2)
                return;
            g.Clear(Color.White);
            for(int i = 0; i < moves.Count && i + 1 < moves.Count; i++)
            {
                var origin = moves[i];
                var destination = moves[i+1];
                Point pOrigin = new Point(origin.Item1, origin.Item2);
                Point pDestination = new Point(destination.Item1, destination.Item2);
                g.DrawLine(p, pOrigin, pDestination);
            }
            moves.Clear();
        }
    }
}