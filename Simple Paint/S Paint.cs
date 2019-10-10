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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creates the variables which are used in the program
        bool drwLine;
        int drwX;
        int drwY;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //when mouse1 is not held down, drwLine is set to false
            drwLine = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //When mouse1 is held down, set drwLine to true and pass mouse coordinates to drwX and drwY
            drwLine = true;
            drwX = e.X;
            drwY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Calls the Graphics method to "g"
            Graphics g = this.CreateGraphics();
            //Creates a pen to paint with to "p"
            Pen p = new Pen(Color.Black, 4);
            //Creates a point variable with drwX and drwY as start point and current mouse point as end point
            Point point1 = new Point(drwX, drwY);
            Point point2 = new Point(e.X, e.Y);
            //checks if you are holding mouse1
            if (drwLine == true)
            {
                //draws a "line" with Pen "p" on point 1 and point 2,
                g.DrawLine(p, point1, point2);
                //sets drwX and Y to current mouse position (NEW point 1 to be used again)
                drwX = e.X;
                drwY = e.Y;
            }
            //gets the coordinates of the mouse on the form and prints it out
            MouseCoordinates.Text = e.X.ToString() + " , " + e.Y.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
