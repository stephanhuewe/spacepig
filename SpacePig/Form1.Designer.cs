namespace Huestel.SpacePig
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.lblGodMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Huestel.SpacePig.Properties.Resources.pig;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.ForeColor = System.Drawing.Color.White;
            this.lblHint.Location = new System.Drawing.Point(10, 152);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(285, 22);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "Leertaste = Start + Schub";
            // 
            // lblDone
            // 
            this.lblDone.BackColor = System.Drawing.Color.Transparent;
            this.lblDone.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.Color.White;
            this.lblDone.Location = new System.Drawing.Point(10, 38);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(285, 104);
            this.lblDone.TabIndex = 3;
            this.lblDone.Text = "Level 1 erfolgreich beendet - A drücken";
            this.lblDone.Visible = false;
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.BackColor = System.Drawing.Color.Transparent;
            this.lblHint2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint2.ForeColor = System.Drawing.Color.White;
            this.lblHint2.Location = new System.Drawing.Point(10, 174);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(175, 22);
            this.lblHint2.TabIndex = 4;
            this.lblHint2.Text = "ESC zum Beenden";
            // 
            // lblGodMode
            // 
            this.lblGodMode.BackColor = System.Drawing.Color.DarkRed;
            this.lblGodMode.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodMode.ForeColor = System.Drawing.Color.White;
            this.lblGodMode.Location = new System.Drawing.Point(-8, -2);
            this.lblGodMode.Name = "lblGodMode";
            this.lblGodMode.Size = new System.Drawing.Size(316, 22);
            this.lblGodMode.TabIndex = 5;
            this.lblGodMode.Text = "!!! Godmode !!!";
            this.lblGodMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGodMode.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Huestel.SpacePig.Properties.Resources.sp300500;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(299, 498);
            this.Controls.Add(this.lblGodMode);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = ".net SpacePig";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.Label lblGodMode;
    }
}

