using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Huestel.SpacePig.Logic.Level;
using Huestel.SpacePig.Logic.Pipe;
using Huestel.SpacePig.Properties;

namespace Huestel.SpacePig
{
    public partial class Form1 : Form
    {
        public Form1(double level, bool wantSound)
        {
            InitializeComponent();
            difficulty = level;
            if (wantSound)
            {
                sp.PlayLooping();
            }
        }

        public event GameBack GameBackEvent;
        public delegate void GameBack(object sender, EventArgs e);

        SoundPlayer sp = new SoundPlayer(Resources.song1);

        private int _lastLevelScore;
        private bool _gameStopped;
        private readonly bool _wantSound = true;

        private bool _pigAlive;
        private bool _end = false;

        Random rand = new Random(1);
        private const int PipeWidth = 55;
        private const int PipeDiffY = 120; // Y Abstand 120
        bool _start = true;
        bool _running;
        double _step = 2;
        private const double originalStep = 2;
        private double difficulty = 1;
        int _originalx;
        int _originaly;
        bool _resetPipes;
        int _points;
        bool _inPipe;
        private LevelManager _levelManager = new LevelManager(1,null);
        private PipePair _currentPipePair;
        private PipePair _followingPipePair;
        private int _levelNumber = 1;
        private const int GameHeight = 500;
        private const int GameWidth = 300;
        private string _godpass = "";
        private bool _godmode = false;

        private void Die()
        {
            _pigAlive = false;
            _running = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            _points = _lastLevelScore;
            pictureBox1.Location = new Point(_originalx, _originaly);
            _resetPipes = true;
            InitializeLevel(_levelNumber);
            lblHint.Visible = true;
            lblHint2.Visible = true;
        }

        

        private void ReadAndShowScore()
        {
            if (_points > 1)
            {
                string name = "Max Mustermann";
                DialogResult result = InputBox.ShowInputBox("Punktestand: " + _points, "Bitte Ihren Namen eingeben:",
                    ref name);
                if (result == DialogResult.OK)
                {
                    Task.Factory.StartNew(() => PostNewHighScore(name));
                }
                
            }
        }

        private void PostNewHighScore(string name)
        {
            Logic.HighScore highScore = new Logic.HighScore();
            highScore.PostScores(name, _points);
        }

        private void StartGame()
        {
            _pigAlive = true;
            _resetPipes = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            _currentPipePair = _levelManager.GetNextPair();
            _followingPipePair = _levelManager.GetNextPair();

            _gameStopped = false;
            
            _running = true;
            _points = _lastLevelScore;
            Focus();
        }
        private void InitializeLevel(int number)
        {
            _levelManager = new LevelManager(GameWidth, rand);
            _levelManager.InitLevels(number);
            _levelManager.CurrentLevelNumber = number;
            _lastLevelScore = _points;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(0,(GameHeight-pictureBox1.Height)/2);
            _originalx = pictureBox1.Location.X;
            _originaly = pictureBox1.Location.Y;
            InitializeLevel(_levelNumber);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_currentPipePair != null && _currentPipePair.UpperPipe.X + PipeWidth <= 0) // | start == true)
            {
                _currentPipePair = _levelManager.GetNextPair();
            }
            else
            {
                if (_currentPipePair != null)
                {
                    _currentPipePair.UpperPipe.X = _currentPipePair.UpperPipe.X - Convert.ToInt32(Math.Round(2 * difficulty));
                    _currentPipePair.LowerPipe.X = _currentPipePair.LowerPipe.X - Convert.ToInt32(Math.Round(2 * difficulty));
                }
            }

           
            if (_followingPipePair != null && _followingPipePair.UpperPipe.X + PipeWidth <= 0)
            {
                _followingPipePair = _levelManager.GetNextPair();
            }
            else
            {
                if (_followingPipePair != null)
                {
                    _followingPipePair.UpperPipe.X = _followingPipePair.UpperPipe.X - Convert.ToInt32(Math.Round(2 * difficulty));
                    _followingPipePair.LowerPipe.X = _followingPipePair.LowerPipe.X - Convert.ToInt32(Math.Round(2 * difficulty));
                }
            }
            if (_start)
            {
                _start = false;
            }

            if (_followingPipePair == null && _currentPipePair == null)
            {
                if (!_gameStopped)
                {
                    _gameStopped = true;

                    lblDone.Text = "Level " + _levelNumber + " erfolgreich beendet! Schwein in Position bringen und A drücken um fortzufahren!";
                    lblDone.Visible = true;

                }
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!_resetPipes && _currentPipePair != null)
            {

                // oben 1
                // Pipe
                e.Graphics.FillRectangle(_currentPipePair.UpperPipe.ColorBrush,
                    new Rectangle(_currentPipePair.UpperPipe.X, 0, PipeWidth, _currentPipePair.UpperPipe.Y));
                // Left
                e.Graphics.FillRectangle(Brushes.DarkRed,
                    new Rectangle(_currentPipePair.UpperPipe.X, 0, 10, _currentPipePair.UpperPipe.Y));
                // Right
                e.Graphics.FillRectangle(Brushes.DarkRed,
                    new Rectangle(_currentPipePair.UpperPipe.X + PipeWidth - 10, 0, 10, _currentPipePair.UpperPipe.Y));
                // Deckel
                e.Graphics.FillRectangle(Brushes.DarkRed,
                    new Rectangle(_currentPipePair.UpperPipe.X - 10, _currentPipePair.LowerPipe.Y - PipeDiffY, 75, 15));

                // unten 1
                e.Graphics.FillRectangle(_currentPipePair.LowerPipe.ColorBrush,
                    new Rectangle(_currentPipePair.LowerPipe.X, _currentPipePair.LowerPipe.Y, PipeWidth,
                        GameHeight - _currentPipePair.LowerPipe.Y));
                // Links
                e.Graphics.FillRectangle(Brushes.Green,
                    new Rectangle(_currentPipePair.LowerPipe.X, _currentPipePair.LowerPipe.Y, 10,
                        GameHeight - _currentPipePair.LowerPipe.Y));
                // Rechts
                e.Graphics.FillRectangle(Brushes.Green,
                    new Rectangle(_currentPipePair.LowerPipe.X + PipeWidth - 10, _currentPipePair.LowerPipe.Y, 10,
                        GameHeight - _currentPipePair.LowerPipe.Y));
                // Deckel
                e.Graphics.FillRectangle(Brushes.Green,
                    new Rectangle(_currentPipePair.LowerPipe.X - 10, _currentPipePair.LowerPipe.Y, 75, 15));
            }
            if (!_resetPipes && _followingPipePair != null)
            {
                // oben 2
                // Pipe
                e.Graphics.FillRectangle(_followingPipePair.UpperPipe.ColorBrush,
                    new Rectangle(_followingPipePair.UpperPipe.X, 0, PipeWidth, _followingPipePair.UpperPipe.Y));
                // Links
                e.Graphics.FillRectangle(Brushes.Yellow,
                    new Rectangle(_followingPipePair.UpperPipe.X, 0, 10, _followingPipePair.UpperPipe.Y));
                // Rechts
                e.Graphics.FillRectangle(Brushes.Yellow,
                    new Rectangle(_followingPipePair.UpperPipe.X + PipeWidth - 10, 0, 10, _followingPipePair.UpperPipe.Y));

                // Deckel
                e.Graphics.FillRectangle(Brushes.Yellow,
                    new Rectangle(_followingPipePair.UpperPipe.X - 10, _followingPipePair.LowerPipe.Y - PipeDiffY, 75,
                        15));


                // unten 2
                // Pipe
                e.Graphics.FillRectangle(_followingPipePair.LowerPipe.ColorBrush,
                    new Rectangle(_followingPipePair.LowerPipe.X, _followingPipePair.LowerPipe.Y, PipeWidth,
                        GameHeight - _followingPipePair.LowerPipe.Y));
                e.Graphics.FillRectangle(Brushes.Purple,
                    new Rectangle(_followingPipePair.LowerPipe.X, _followingPipePair.LowerPipe.Y, 10,
                        GameHeight - _followingPipePair.LowerPipe.Y));
                e.Graphics.FillRectangle(Brushes.Purple,
                    new Rectangle(_followingPipePair.LowerPipe.X + PipeWidth - 10, _followingPipePair.LowerPipe.Y, 10,
                        GameHeight - _followingPipePair.LowerPipe.Y));

                // Deckel
                e.Graphics.FillRectangle(Brushes.Purple,
                    new Rectangle(_followingPipePair.LowerPipe.X - 10, _followingPipePair.LowerPipe.Y, 75, 15));
            }
        }

        private void CheckForScore()
        {
            if (_currentPipePair != null && _followingPipePair != null)
            {
                Rectangle rec = pictureBox1.Bounds;
                Rectangle rec1 = new Rectangle(_currentPipePair.LowerPipe.X + 20,
                    _currentPipePair.LowerPipe.Y - PipeDiffY, 15, PipeDiffY);
                Rectangle rec2 = new Rectangle(_followingPipePair.LowerPipe.X + 20,
                    _followingPipePair.LowerPipe.Y - PipeDiffY, 15, PipeDiffY);
                Rectangle intersect1 = Rectangle.Intersect(rec, rec1);
                Rectangle intersect2 = Rectangle.Intersect(rec, rec2);
                if (!_resetPipes | _start)
                {
                    if (intersect1 != Rectangle.Empty | intersect2 != Rectangle.Empty)
                    {
                        if (!_inPipe)
                        {
                            if (!_godmode)
                            {
                                _points = _points + Convert.ToInt32(Math.Round(difficulty, 0));
                            }
                            //SoundPlayer sp = new SoundPlayer(WindowsFormsApplication5.Properties.Resources.point);
                            //sp.Play();
                            _inPipe = true;
                        }
                    }
                    else
                    {
                        _inPipe = false;
                    }
                }
            }
        }

        private void CheckForCrash()
        {
            if (_currentPipePair != null & _followingPipePair != null)
            {
                Rectangle rec = pictureBox1.Bounds;
                rec.Height -= 10;
                rec.Width -= 10;
                Rectangle rec1 = new Rectangle(_currentPipePair.UpperPipe.X, 0, PipeWidth, _currentPipePair.UpperPipe.Y);
                Rectangle rec2 = new Rectangle(_currentPipePair.LowerPipe.X, _currentPipePair.LowerPipe.Y, PipeWidth,
                    GameHeight - _currentPipePair.LowerPipe.Y);
                Rectangle rec3 = new Rectangle(_followingPipePair.UpperPipe.X, 0, PipeWidth,
                    _followingPipePair.UpperPipe.Y);
                Rectangle rec4 = new Rectangle(_followingPipePair.LowerPipe.X, _followingPipePair.LowerPipe.Y, PipeWidth,
                    GameHeight - _followingPipePair.LowerPipe.Y);
                Rectangle intersect1 = Rectangle.Intersect(rec, rec1);
                Rectangle intersect2 = Rectangle.Intersect(rec, rec2);
                Rectangle intersect3 = Rectangle.Intersect(rec, rec3);
                Rectangle intersect4 = Rectangle.Intersect(rec, rec4);
                if (!_resetPipes | _start)
                {
                    if (intersect1 != Rectangle.Empty | intersect2 != Rectangle.Empty | intersect3 != Rectangle.Empty |
                        intersect4 != Rectangle.Empty)
                    {
                        if (!_godmode)
                        {
                            Die();
                        }
                    }
                }
            }
        }

// ReSharper disable once InconsistentNaming
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (!_pigAlive)
                    {
                        StartGame();
                    }
                    lblHint.Visible = false;
                    lblHint2.Visible = false;
                    ChangeStepping(-originalStep);
                    pictureBox1.Image = Resources.pig;
                    break;
                case Keys.A:
                    if (_gameStopped)
                    {
                        _gameStopped = false;
                        lblDone.Visible = false;
                        _levelNumber++;
                        InitializeLevel(_levelNumber);
                        StartGame();
                    }
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    _godpass += e.KeyData;
                    if (_godpass.Contains("IDDQD"))
                    {
                        _godmode = true;
                        lblGodMode.Visible = true;
                    }
                    break;
            }
        }

        private void ChangeStepping(double value)
        {
            _step = value*difficulty;
        }

        private bool ExitGame()
        {
            if (
                MessageBox.Show("Möchten Sie das Spiel beenden?", "Spiel beenden", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReadAndShowScore();
                if (this.GameBackEvent != null)
                {
                    GameBackEvent(this, null);
                }
                return false;
            }
            else
            {
                return true;
            }
        }

// ReSharper disable once InconsistentNaming
        private void timer3_Tick(object sender, EventArgs e)
        {
            // Move
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + Convert.ToInt32(Math.Round(_step,0)));
            
            // Check upper bound
            if (pictureBox1.Location.Y < 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
            }
            // Check lower bound
            if (pictureBox1.Location.Y + pictureBox1.Height > GameHeight)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, GameHeight - pictureBox1.Height);
            }
            CheckForCrash();
            if (_running)
            {
                CheckForScore();
            }

            Text = @"Level " + _levelNumber + @" | Punkte: " + Convert.ToString(_points);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    ChangeStepping(originalStep);
                    pictureBox1.Image = Resources.pigdown; 
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_end)
            {
                _end = true;
                e.Cancel = ExitGame();
                if (!e.Cancel)
                {
                    sp.Stop();
                    _end = true;
                }
                _end = false;

            }
        }

        
    }
}