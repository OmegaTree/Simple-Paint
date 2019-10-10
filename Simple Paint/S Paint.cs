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

                                                                                         //Creates all elements used globally
        List<(int, int)> moves = new List<(int, int)>();
        bool drawLine;
        int drawX;
        int drawY;
        Timer tmr;
        int counter;
        Graphics g;
        public static bool drawClear;
        public static int pSize = 4;
        public static Color colourChosen = Color.Black;
        public static Pen p = new Pen(colourChosen, pSize);

                                                                                        // Forms spawned through buttons.
        ColourChooser subPicker = new ColourChooser();
        ClearScreen subClear = new ClearScreen();

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drawLine = false;
        }
                                                                                        //Internal clock
        private void Clock()
        {
                                                                                        //Creates a timer that counts and updates every secound
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(TmrTick);
            tmr.Enabled = true;
        }
        void TmrTick(object sender, EventArgs e)
        {
                                                                                        //On each timer tick, add current date to txtTimer.Text
            txtTimer.Text = DateTime.Now.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drawLine = true;
            drawX = e.X;
            drawY = e.Y;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            Point point1 = new Point(drawX, drawY);
            Point point2 = new Point(e.X, e.Y);
                                                                                        //Disables drawing at the menu boundary
            if (drawX < 200)
            {
                drawLine = false;
            }
            if (drawLine == true)
            {
                g.DrawLine(p, point1, point2);
                drawX = e.X;
                drawY = e.Y;
                moves.Add((drawX, drawY));
            }
            MouseInputs(e);

        }
                                                                                        //Mouse input handler for position on canvas and pixels moved
        private void MouseInputs(MouseEventArgs e)
        {                                                                                                   
            int mseCoordinate = e.X - 200;                                              
            MouseCoordinates.Text = mseCoordinate.ToString() + " , " + e.Y.ToString();  // Prints mouse coordinates
            counter++;
            lblCounter.Text = counter.ToString();
        }
                                                                                        //draws your drawing again if you press "Replay"
        private void ReplayDraw()
        {
            if (moves.Count < 2)                                                        //checks if you have drawn
                return;
            g.Clear(Color.White);                                                       //clears the board
            for (int i = 0; i < moves.Count && i + 1 < moves.Count; i++)                //loops through the moves list
            {
                var origin = moves[i];                                                  //Creates the start variable
                var destination = moves[i + 1];                                         //Defines the end variable
                Point pOrigin = new Point(origin.Item1, origin.Item2);                  //Creates a starting point on the canvas using the data stored in the list
                Point pDestination = new Point(destination.Item1, destination.Item2);   //creates an ending point using data stored in the list
                g.DrawLine(p, pOrigin, pDestination);                                   //Draws line from origin to destination point
            }
        }
                                                                                        //opens a form which asks for confirmation before clearing
        private void OpenClearForm()
        {
            subClear.ShowDialog();                                                      //Opens the dialog Form
            if (drawClear == true)
            {
                g.Clear(Color.White);                                                   //If drawClear is true, fill the whole Canvas white
                drawClear = false;
            }
            drawClear = false;
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
            p = new Pen(colourChosen, 4);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenClearForm();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtTimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnReplay_Click(object sender, EventArgs e)
        {
            ReplayDraw();
        }

        private void BtnReplayClear_Click(object sender, EventArgs e)
        {
            moves.Clear();
        }
    }
}