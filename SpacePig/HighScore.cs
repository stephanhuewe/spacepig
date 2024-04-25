using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Huestel.SpacePig
{
    public partial class HighScore : Form
    {
        public event HighscoreBack HighscoreBackEvent;
        public delegate void HighscoreBack(object sender, EventArgs e);

        public HighScore(List<string> highscoreList )
        {
            InitializeComponent();
            ShowHighScore(highscoreList);
        }

        private void ShowHighScore(List<string> highscoreList)
        {
            int counter = 1;
            foreach (string value in highscoreList)
            {
                if (!String.IsNullOrEmpty(value))
                {
                    listBox1.Items.Add(counter + ". " + value);
                    counter++;
                    
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (HighscoreBackEvent != null)
            {
                HighscoreBackEvent(this, null);
            }
        }
    }
}
