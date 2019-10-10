namespace Simple_Paint
{
    partial class ColourChooser
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
            this.clrWhite = new System.Windows.Forms.Button();
            this.clrBlack = new System.Windows.Forms.Button();
            this.clrRed = new System.Windows.Forms.Button();
            this.clrYellow = new System.Windows.Forms.Button();
            this.clrCyan = new System.Windows.Forms.Button();
            this.clrMagenta = new System.Windows.Forms.Button();
            this.clrBlue = new System.Windows.Forms.Button();
            this.clrGreen = new System.Windows.Forms.Button();
            this.ereaser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clrWhite
            // 
            this.clrWhite.BackColor = System.Drawing.Color.White;
            this.clrWhite.ForeColor = System.Drawing.Color.White;
            this.clrWhite.Location = new System.Drawing.Point(81, 12);
            this.clrWhite.Name = "clrWhite";
            this.clrWhite.Size = new System.Drawing.Size(40, 40);
            this.clrWhite.TabIndex = 0;
            this.clrWhite.Text = "White";
            this.clrWhite.UseVisualStyleBackColor = false;
            // 
            // clrBlack
            // 
            this.clrBlack.BackColor = System.Drawing.Color.Black;
            this.clrBlack.ForeColor = System.Drawing.Color.Black;
            this.clrBlack.Location = new System.Drawing.Point(35, 12);
            this.clrBlack.Name = "clrBlack";
            this.clrBlack.Size = new System.Drawing.Size(40, 40);
            this.clrBlack.TabIndex = 1;
            this.clrBlack.Text = "Black";
            this.clrBlack.UseVisualStyleBackColor = false;
            this.clrBlack.Click += new System.EventHandler(this.Button1_Click);
            // 
            // clrRed
            // 
            this.clrRed.BackColor = System.Drawing.Color.Red;
            this.clrRed.ForeColor = System.Drawing.Color.Red;
            this.clrRed.Location = new System.Drawing.Point(35, 58);
            this.clrRed.Name = "clrRed";
            this.clrRed.Size = new System.Drawing.Size(40, 40);
            this.clrRed.TabIndex = 2;
            this.clrRed.Text = "Red";
            this.clrRed.UseVisualStyleBackColor = false;
            this.clrRed.Click += new System.EventHandler(this.ClrRed_Click);
            // 
            // clrYellow
            // 
            this.clrYellow.BackColor = System.Drawing.Color.Yellow;
            this.clrYellow.ForeColor = System.Drawing.Color.Yellow;
            this.clrYellow.Location = new System.Drawing.Point(127, 104);
            this.clrYellow.Name = "clrYellow";
            this.clrYellow.Size = new System.Drawing.Size(40, 40);
            this.clrYellow.TabIndex = 7;
            this.clrYellow.Text = "Green";
            this.clrYellow.UseVisualStyleBackColor = false;
            this.clrYellow.Click += new System.EventHandler(this.ClrYellow_Click);
            // 
            // clrCyan
            // 
            this.clrCyan.BackColor = System.Drawing.Color.Cyan;
            this.clrCyan.ForeColor = System.Drawing.Color.Cyan;
            this.clrCyan.Location = new System.Drawing.Point(35, 104);
            this.clrCyan.Name = "clrCyan";
            this.clrCyan.Size = new System.Drawing.Size(40, 40);
            this.clrCyan.TabIndex = 6;
            this.clrCyan.Text = "Green";
            this.clrCyan.UseVisualStyleBackColor = false;
            this.clrCyan.Click += new System.EventHandler(this.ClrCyan_Click);
            // 
            // clrMagenta
            // 
            this.clrMagenta.BackColor = System.Drawing.Color.Magenta;
            this.clrMagenta.ForeColor = System.Drawing.Color.Magenta;
            this.clrMagenta.Location = new System.Drawing.Point(81, 104);
            this.clrMagenta.Name = "clrMagenta";
            this.clrMagenta.Size = new System.Drawing.Size(40, 40);
            this.clrMagenta.TabIndex = 5;
            this.clrMagenta.Text = "Green";
            this.clrMagenta.UseVisualStyleBackColor = false;
            this.clrMagenta.Click += new System.EventHandler(this.ClrMagenta_Click);
            // 
            // clrBlue
            // 
            this.clrBlue.BackColor = System.Drawing.Color.Blue;
            this.clrBlue.ForeColor = System.Drawing.Color.Blue;
            this.clrBlue.Location = new System.Drawing.Point(127, 58);
            this.clrBlue.Name = "clrBlue";
            this.clrBlue.Size = new System.Drawing.Size(40, 40);
            this.clrBlue.TabIndex = 4;
            this.clrBlue.Text = "Green";
            this.clrBlue.UseVisualStyleBackColor = false;
            this.clrBlue.Click += new System.EventHandler(this.ClrBlue_Click);
            // 
            // clrGreen
            // 
            this.clrGreen.BackColor = System.Drawing.Color.Green;
            this.clrGreen.ForeColor = System.Drawing.Color.Green;
            this.clrGreen.Location = new System.Drawing.Point(81, 58);
            this.clrGreen.Name = "clrGreen";
            this.clrGreen.Size = new System.Drawing.Size(40, 40);
            this.clrGreen.TabIndex = 12;
            this.clrGreen.Text = "Green";
            this.clrGreen.UseVisualStyleBackColor = false;
            this.clrGreen.Click += new System.EventHandler(this.ClrGreen_Click);
            // 
            // ereaser
            // 
            this.ereaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ereaser.ForeColor = System.Drawing.Color.Transparent;
            this.ereaser.Location = new System.Drawing.Point(127, 12);
            this.ereaser.Name = "ereaser";
            this.ereaser.Size = new System.Drawing.Size(40, 40);
            this.ereaser.TabIndex = 13;
            this.ereaser.Text = "Ereaser";
            this.ereaser.UseVisualStyleBackColor = false;
            this.ereaser.Click += new System.EventHandler(this.Ereaser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(65, 204);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ColourChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 270);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ereaser);
            this.Controls.Add(this.clrGreen);
            this.Controls.Add(this.clrYellow);
            this.Controls.Add(this.clrCyan);
            this.Controls.Add(this.clrMagenta);
            this.Controls.Add(this.clrBlue);
            this.Controls.Add(this.clrRed);
            this.Controls.Add(this.clrBlack);
            this.Controls.Add(this.clrWhite);
            this.Name = "ColourChooser";
            this.Text = "ColourChooser";
            this.Load += new System.EventHandler(this.ColourChooser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clrWhite;
        private System.Windows.Forms.Button clrBlack;
        private System.Windows.Forms.Button clrRed;
        private System.Windows.Forms.Button clrYellow;
        private System.Windows.Forms.Button clrCyan;
        private System.Windows.Forms.Button clrMagenta;
        private System.Windows.Forms.Button clrBlue;
        private System.Windows.Forms.Button clrGreen;
        private System.Windows.Forms.Button ereaser;
        private System.Windows.Forms.Button btnClose;
    }
}