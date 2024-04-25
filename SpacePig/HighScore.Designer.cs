namespace Huestel.SpacePig
{
    partial class HighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.ForeColor = System.Drawing.Color.Black;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 277);
            this.listBox1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBack.Location = new System.Drawing.Point(60, 386);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Zurück";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Highscores:";
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Huestel.SpacePig.Properties.Resources.sp300500;
            this.ClientSize = new System.Drawing.Size(303, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;

    }
}