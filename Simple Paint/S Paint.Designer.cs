namespace Simple_Paint
{
    partial class SPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPaint));
            this.MouseCoordinates = new System.Windows.Forms.TextBox();
            this.btnColorChooser = new System.Windows.Forms.Button();
            this.btnClearCanvas = new System.Windows.Forms.Button();
            this.imgSPaint = new System.Windows.Forms.PictureBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.txtTimer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSPaint)).BeginInit();
            this.grpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MouseCoordinates
            // 
            this.MouseCoordinates.Enabled = false;
            this.MouseCoordinates.Location = new System.Drawing.Point(107, 649);
            this.MouseCoordinates.Name = "MouseCoordinates";
            this.MouseCoordinates.ReadOnly = true;
            this.MouseCoordinates.Size = new System.Drawing.Size(100, 20);
            this.MouseCoordinates.TabIndex = 0;
            this.MouseCoordinates.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnColorChooser
            // 
            this.btnColorChooser.Location = new System.Drawing.Point(6, 19);
            this.btnColorChooser.Name = "btnColorChooser";
            this.btnColorChooser.Size = new System.Drawing.Size(75, 23);
            this.btnColorChooser.TabIndex = 4;
            this.btnColorChooser.Text = "Colour";
            this.btnColorChooser.UseVisualStyleBackColor = true;
            this.btnColorChooser.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnClearCanvas
            // 
            this.btnClearCanvas.Location = new System.Drawing.Point(6, 48);
            this.btnClearCanvas.Name = "btnClearCanvas";
            this.btnClearCanvas.Size = new System.Drawing.Size(75, 23);
            this.btnClearCanvas.TabIndex = 5;
            this.btnClearCanvas.Text = "Clear";
            this.btnClearCanvas.UseVisualStyleBackColor = true;
            this.btnClearCanvas.Click += new System.EventHandler(this.Button2_Click);
            // 
            // imgSPaint
            // 
            this.imgSPaint.ImageLocation = "C:\\Users\\d4114\\source\\repos\\Simple Paint\\Simple Paint\\SPaint.png";
            this.imgSPaint.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgSPaint.InitialImage")));
            this.imgSPaint.Location = new System.Drawing.Point(6, 447);
            this.imgSPaint.Name = "imgSPaint";
            this.imgSPaint.Size = new System.Drawing.Size(200, 178);
            this.imgSPaint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSPaint.TabIndex = 6;
            this.imgSPaint.TabStop = false;
            this.imgSPaint.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.txtTimer);
            this.grpControl.Controls.Add(this.btnColorChooser);
            this.grpControl.Controls.Add(this.MouseCoordinates);
            this.grpControl.Controls.Add(this.imgSPaint);
            this.grpControl.Controls.Add(this.btnClearCanvas);
            this.grpControl.Location = new System.Drawing.Point(-1, 0);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(213, 683);
            this.grpControl.TabIndex = 7;
            this.grpControl.TabStop = false;
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(6, 421);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(201, 20);
            this.txtTimer.TabIndex = 8;
            this.txtTimer.TextChanged += new System.EventHandler(this.TxtTimer_TextChanged);
            // 
            // SPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpControl);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "SPaint";
            this.Text = "SPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.imgSPaint)).EndInit();
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MouseCoordinates;
        private System.Windows.Forms.Button btnColorChooser;
        private System.Windows.Forms.Button btnClearCanvas;
        private System.Windows.Forms.PictureBox imgSPaint;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.TextBox txtTimer;
    }
}

