using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huestel.SpacePig
{
    public partial class StartUp : Form
    {
        private HighScore highScore = null;
        private Form1 form1 = null;
        List<string> _highScores = new List<string>(); 

        public StartUp()
        {
            InitializeComponent();
            this.btnHighscore.Enabled = false;
            Task.Factory.StartNew(() => GetHighScores());
        }

        private void GetHighScores()
        {
            try
            {
                Logic.HighScore highScore = new Logic.HighScore();
                List<string> values = highScore.GetHighScoreValues();
                _highScores = values;

                this.Invoke((MethodInvoker) delegate
                                            {
                                                this.btnHighscore.Enabled = true;
                                            });
            }
            catch (Exception)
            {

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double level = 1;

            if (this.radioButton2.Checked)
            {
                level = 1.5;
            }
            if (this.radioButton3.Checked)
            {
                level = 2;
            }

            this.Hide();
            form1 = new Form1(level,checkBox1.Checked);
            form1.GameBackEvent += form1_GameBackEvent;
            form1.Location = this.Location;
            form1.Show(this);
        }

        void form1_GameBackEvent(object sender, EventArgs e)
        {
            this.Location = form1.Location;
            form1.Close();
            this.Show();
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (highScore == null || highScore.IsDisposed)
            {
                highScore = new HighScore(_highScores);
            }

            highScore.HighscoreBackEvent += highScore_HighscoreBackEvent;
            highScore.Location = this.Location;
            highScore.Show();
        }

        void highScore_HighscoreBackEvent(object sender, EventArgs e)
        {
            this.Location = highScore.Location;
            highScore.Close();
            this.Show();

        }

        private void StartUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (highScore != null) highScore.Close();
            if (form1 != null) form1.Close();
            Application.Exit();
        }
    }
}
