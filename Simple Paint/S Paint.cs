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
        //Creates the variables which are used in the program
        bool drwLine;
        int drwX;
        int drwY;
        Timer tmr;
        Stopwatch currentTime = new Stopwatch();
        public static bool drwClear;
        public static int pSize = 4;
        public static Color clrChosen = Color.Black;
        //Calls the Graphics method to "g"
        Graphics g;
        //Creates a pen to paint with to "p"
        public static Pen p = new Pen(clrChosen, pSize);

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //when no mouse buttons are held down, drwLine is set to false
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
            //When a mouse button is held down, set drwLine to true and pass mouse coordinates to drwX and drwY
            drwLine = true;
            drwX = e.X;
            drwY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Creates a point variable with drwX and drwY as start point and current mouse point as end point
            Point point1 = new Point(drwX, drwY);
            Point point2 = new Point(e.X, e.Y);
            if (drwX < 200)
            {
                drwLine = false;
            }
            //checks if you are pressing a mouse button
            if (drwLine == true)
            {

                //draws a "line" with Pen "p" on point 1 and point 2,
                g.DrawLine(p, point1, point2);
                //sets drwX and Y to current mouse position (NEW point 1 to be used again)
                drwX = e.X;
                drwY = e.Y;
            }
            //gets the coordinates of the mouse on the form and prints it out to a box
            int mseCoordinate = e.X - 200;
            MouseCoordinates.Text = mseCoordinate.ToString() + " , " + e.Y.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            ColourChooser clrForm = new ColourChooser();
            clrForm.ShowDialog();
            p = new Pen(clrChosen, 4);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ClearScreen clear = new ClearScreen();
            clear.ShowDialog();
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
    }
}