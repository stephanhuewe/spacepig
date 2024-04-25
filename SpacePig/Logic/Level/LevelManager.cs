using System;
using System.Drawing;
using Huestel.SpacePig.Logic.Pipe;
using Huestel.SpacePig.Properties;

namespace Huestel.SpacePig.Logic.Level
{
    public class LevelManager
    {
        private readonly int _gameWidth;
        private Random _random;
        private Level _currentLevel;

        public int CurrentLevelNumber
        {
            get { return _currentLevelNumber; }
            set
            {
                _currentLevelNumber = value;
                _currentLevel = InitLevels(value);
            }
        }


        private int _currentPipe;
        private int _currentLevelNumber;

        public LevelManager(int width, Random random)
        {
            _gameWidth = width;
            _random = random;
        }

        public PipePair GetNextPair()
        {
            if (_currentLevel.Pipes.Count > _currentPipe)
            {
                PipePair pipes = _currentLevel.Pipes[_currentPipe];
                _currentPipe++;
                return pipes;
            }
            return null;
        }

        public Level InitLevels(int number)
        {
            Level ret = new Level();

            if (number == 1)
            {
                Pipe.Pipe pipeU1 = new Pipe.Pipe(300, 300, 359, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL1 = new Pipe.Pipe(300, 420, 479, new TextureBrush(GetRandomImage()));
                PipePair pair1 = new PipePair(pipeU1, pipeL1);
                ret.Pipes.Add(pair1);

                Pipe.Pipe pipeU2 = new Pipe.Pipe(480, 290, 300, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL2 = new Pipe.Pipe(480, 410, 420, new TextureBrush(GetRandomImage()));
                PipePair pair2 = new PipePair(pipeU2, pipeL2);
                ret.Pipes.Add(pair2);

                Pipe.Pipe pipeU3 = new Pipe.Pipe(300, 300, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL3 = new Pipe.Pipe(300, 420, 100, new TextureBrush(GetRandomImage()));
                PipePair pair3 = new PipePair(pipeU3, pipeL3);
                ret.Pipes.Add(pair3);

                Pipe.Pipe pipeU4 = new Pipe.Pipe(300, 290, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL4 = new Pipe.Pipe(300, 410, 100, new TextureBrush(GetRandomImage()));
                PipePair pair4 = new PipePair(pipeU4, pipeL4);
                ret.Pipes.Add(pair4);

                Pipe.Pipe pipeU5 = new Pipe.Pipe(300, 300, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL5 = new Pipe.Pipe(300, 420, 100, new TextureBrush(GetRandomImage()));
                PipePair pair5 = new PipePair(pipeU5, pipeL5);
                ret.Pipes.Add(pair5);
                
            }
            if (number == 2)
            {
                Pipe.Pipe pipeU1 = new Pipe.Pipe(300, 250, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL1 = new Pipe.Pipe(300, 370, 100, new TextureBrush(GetRandomImage()));
                PipePair pair1 = new PipePair(pipeU1, pipeL1);
                ret.Pipes.Add(pair1);

                Pipe.Pipe pipeU2 = new Pipe.Pipe(480, 135, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL2 = new Pipe.Pipe(480, 255, 100, new TextureBrush(GetRandomImage()));
                PipePair pair2 = new PipePair(pipeU2, pipeL2);
                ret.Pipes.Add(pair2);

                Pipe.Pipe pipeU3 = new Pipe.Pipe(300, 90, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL3 = new Pipe.Pipe(300, 210, 100, new TextureBrush(GetRandomImage()));
                PipePair pair3 = new PipePair(pipeU3, pipeL3);
                ret.Pipes.Add(pair3);

                Pipe.Pipe pipeU4 = new Pipe.Pipe(300, 150, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL4 = new Pipe.Pipe(300, 270, 100, new TextureBrush(GetRandomImage()));
                PipePair pair4 = new PipePair(pipeU4, pipeL4);
                ret.Pipes.Add(pair4);

                Pipe.Pipe pipeU5 = new Pipe.Pipe(300, 200, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL5 = new Pipe.Pipe(300, 320, 100, new TextureBrush(GetRandomImage()));
                PipePair pair5 = new PipePair(pipeU5, pipeL5);
                ret.Pipes.Add(pair5);

                Pipe.Pipe pipeU6 = new Pipe.Pipe(300, 125, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL6 = new Pipe.Pipe(300, 245, 100, new TextureBrush(GetRandomImage()));
                PipePair pair6 = new PipePair(pipeU6, pipeL6);
                ret.Pipes.Add(pair6);

                Pipe.Pipe pipeU7 = new Pipe.Pipe(300, 200, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL7 = new Pipe.Pipe(300, 320, 100, new TextureBrush(GetRandomImage()));
                PipePair pair7 = new PipePair(pipeU7, pipeL7);
                ret.Pipes.Add(pair7);
                
            }
            if (number == 3)
            {
                Pipe.Pipe pipeU1 = new Pipe.Pipe(300, 50, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL1 = new Pipe.Pipe(300, 170, 100, new TextureBrush(GetRandomImage()));
                PipePair pair1 = new PipePair(pipeU1, pipeL1);
                ret.Pipes.Add(pair1);

                Pipe.Pipe pipeU2 = new Pipe.Pipe(480, 100, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL2 = new Pipe.Pipe(480, 220, 100, new TextureBrush(GetRandomImage()));
                PipePair pair2 = new PipePair(pipeU2, pipeL2);
                ret.Pipes.Add(pair2);

                Pipe.Pipe pipeU3 = new Pipe.Pipe(300, 50, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL3 = new Pipe.Pipe(300, 170, 100, new TextureBrush(GetRandomImage()));
                PipePair pair3 = new PipePair(pipeU3, pipeL3);
                ret.Pipes.Add(pair3);

                Pipe.Pipe pipeU4 = new Pipe.Pipe(300, 80, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL4 = new Pipe.Pipe(300, 200, 100, new TextureBrush(GetRandomImage()));
                PipePair pair4 = new PipePair(pipeU4, pipeL4);
                ret.Pipes.Add(pair4);

                Pipe.Pipe pipeU5 = new Pipe.Pipe(300, 120, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL5 = new Pipe.Pipe(300, 240, 100, new TextureBrush(GetRandomImage()));
                PipePair pair5 = new PipePair(pipeU5, pipeL5);
                ret.Pipes.Add(pair5);

                Pipe.Pipe pipeU6 = new Pipe.Pipe(300, 160, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL6 = new Pipe.Pipe(300, 280, 100, new TextureBrush(GetRandomImage()));
                PipePair pair6 = new PipePair(pipeU6, pipeL6);
                ret.Pipes.Add(pair6);

                Pipe.Pipe pipeU7 = new Pipe.Pipe(300, 70, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL7 = new Pipe.Pipe(300, 190, 100, new TextureBrush(GetRandomImage()));
                PipePair pair7 = new PipePair(pipeU7, pipeL7);
                ret.Pipes.Add(pair7);

                Pipe.Pipe pipeU8 = new Pipe.Pipe(300, 90, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL8 = new Pipe.Pipe(300, 210, 100, new TextureBrush(GetRandomImage()));
                PipePair pair8 = new PipePair(pipeU8, pipeL8);
                ret.Pipes.Add(pair8);

                Pipe.Pipe pipeU9 = new Pipe.Pipe(300, 150, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL9 = new Pipe.Pipe(300, 270, 100, new TextureBrush(GetRandomImage()));
                PipePair pair9 = new PipePair(pipeU9, pipeL9);
                ret.Pipes.Add(pair9);

                Pipe.Pipe pipeU10 = new Pipe.Pipe(300, 130, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL10 = new Pipe.Pipe(300, 250, 100, new TextureBrush(GetRandomImage()));
                PipePair pair10 = new PipePair(pipeU10, pipeL10);
                ret.Pipes.Add(pair10);
            }

            if (number == 4)
            {
                Pipe.Pipe pipeU1 = new Pipe.Pipe(_gameWidth, 150, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL1 = new Pipe.Pipe(_gameWidth, 270, 100, new TextureBrush(GetRandomImage()));
                PipePair pair1 = new PipePair(pipeU1, pipeL1);
                ret.Pipes.Add(pair1);

                Pipe.Pipe pipeU2 = new Pipe.Pipe(480, 80, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL2 = new Pipe.Pipe(480, 200, 100, new TextureBrush(GetRandomImage()));
                PipePair pair2 = new PipePair(pipeU2, pipeL2);
                ret.Pipes.Add(pair2);

                Pipe.Pipe pipeU3 = new Pipe.Pipe(_gameWidth, 100, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL3 = new Pipe.Pipe(_gameWidth, 220, 100, new TextureBrush(GetRandomImage()));
                PipePair pair3 = new PipePair(pipeU3, pipeL3);
                ret.Pipes.Add(pair3);

                Pipe.Pipe pipeU4 = new Pipe.Pipe(_gameWidth, 140, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL4 = new Pipe.Pipe(_gameWidth, 260, 100, new TextureBrush(GetRandomImage()));
                PipePair pair4 = new PipePair(pipeU4, pipeL4);
                ret.Pipes.Add(pair4);

                Pipe.Pipe pipeU5 = new Pipe.Pipe(_gameWidth, 80, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL5 = new Pipe.Pipe(_gameWidth, 200, 100, new TextureBrush(GetRandomImage()));
                PipePair pair5 = new PipePair(pipeU5, pipeL5);
                ret.Pipes.Add(pair5);

                Pipe.Pipe pipeU6 = new Pipe.Pipe(_gameWidth, 100, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL6 = new Pipe.Pipe(_gameWidth, 220, 100, new TextureBrush(GetRandomImage()));
                PipePair pair6 = new PipePair(pipeU6, pipeL6);
                ret.Pipes.Add(pair6);

                Pipe.Pipe pipeU7 = new Pipe.Pipe(_gameWidth, 150, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL7 = new Pipe.Pipe(_gameWidth, 270, 100, new TextureBrush(GetRandomImage()));
                PipePair pair7 = new PipePair(pipeU7, pipeL7);
                ret.Pipes.Add(pair7);

                Pipe.Pipe pipeU8 = new Pipe.Pipe(_gameWidth, 170, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL8 = new Pipe.Pipe(_gameWidth, 290, 100, new TextureBrush(GetRandomImage()));
                PipePair pair8 = new PipePair(pipeU8, pipeL8);
                ret.Pipes.Add(pair8);

                Pipe.Pipe pipeU9 = new Pipe.Pipe(_gameWidth, 190, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL9 = new Pipe.Pipe(_gameWidth, 310, 100, new TextureBrush(GetRandomImage()));
                PipePair pair9 = new PipePair(pipeU9, pipeL9);
                ret.Pipes.Add(pair9);

                Pipe.Pipe pipeU10 = new Pipe.Pipe(_gameWidth, 120, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL10 = new Pipe.Pipe(_gameWidth, 240, 100, new TextureBrush(GetRandomImage()));
                PipePair pair10 = new PipePair(pipeU10, pipeL10);
                ret.Pipes.Add(pair10);

                Pipe.Pipe pipeU11 = new Pipe.Pipe(_gameWidth, 100, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL11 = new Pipe.Pipe(_gameWidth, 220, 100, new TextureBrush(GetRandomImage()));
                PipePair pair11 = new PipePair(pipeU11, pipeL11);
                ret.Pipes.Add(pair11);

                Pipe.Pipe pipeU12 = new Pipe.Pipe(_gameWidth, 120, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL12 = new Pipe.Pipe(_gameWidth, 240, 100, new TextureBrush(GetRandomImage()));
                PipePair pair12 = new PipePair(pipeU12, pipeL12);
                ret.Pipes.Add(pair12);

                Pipe.Pipe pipeU13 = new Pipe.Pipe(_gameWidth, 250, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL13 = new Pipe.Pipe(_gameWidth, 370, 100, new TextureBrush(GetRandomImage()));
                PipePair pair13 = new PipePair(pipeU13, pipeL13);
                ret.Pipes.Add(pair13);

                Pipe.Pipe pipeU14 = new Pipe.Pipe(_gameWidth, 200, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL14 = new Pipe.Pipe(_gameWidth, 320, 100, new TextureBrush(GetRandomImage()));
                PipePair pair14 = new PipePair(pipeU14, pipeL14);
                ret.Pipes.Add(pair14);

                Pipe.Pipe pipeU15 = new Pipe.Pipe(_gameWidth, 80, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL15 = new Pipe.Pipe(_gameWidth, 200, 100, new TextureBrush(GetRandomImage()));
                PipePair pair15 = new PipePair(pipeU15, pipeL15);
                ret.Pipes.Add(pair15);
            }
            
            // After that only random levels until forever :-)
            if (number > 4)
            {
                Random random = new Random();
                int space = 40;
                int num = random.Next(space, 500 - 120);
                int num1 = num + 120;

                Pipe.Pipe pipeU = new Pipe.Pipe(300, num, 100, new TextureBrush(GetRandomImage()));
                Pipe.Pipe pipeL = new Pipe.Pipe(300, num1, 100, new TextureBrush(GetRandomImage()));
                PipePair pair = new PipePair(pipeU, pipeL);
                ret.Pipes.Add(pair);

                num = random.Next(space, (500 - 120));
                num1 = num + 120;

                pipeU = new Pipe.Pipe(480, num, 100, new TextureBrush(GetRandomImage()));
                pipeL = new Pipe.Pipe(480, num1, 100, new TextureBrush(GetRandomImage()));
                pair = new PipePair(pipeU, pipeL);
                ret.Pipes.Add(pair);


                for (int i = 0; i < number*3; i++)
                {
                    int px = _gameWidth;
                    int py = _random.Next(40, (500 - 120));
                    var p2X = px;
                    var p2Y = py + 120;
                    
                    pipeU = new Pipe.Pipe(300, py, 100, new TextureBrush(GetRandomImage()));
                    pipeL = new Pipe.Pipe(300, p2Y, 100, new TextureBrush(GetRandomImage()));
                    pair = new PipePair(pipeU, pipeL);
                    ret.Pipes.Add(pair);

                    py = _random.Next(40, (500 - 120));
                    p2Y = py + 120;

                    pipeU = new Pipe.Pipe(300, py, 100, new TextureBrush(GetRandomImage()));
                    pipeL = new Pipe.Pipe(300, p2Y, 100, new TextureBrush(GetRandomImage()));
                    pair = new PipePair(pipeU, pipeL);
                    ret.Pipes.Add(pair);


                }
            }


            return ret;
        }

        private Image GetRandomImage()
        {
            int number = _random.Next(1, 7);

            if (number == 1)
            {
                return Resources.moon;
            }

            if (number == 2)
            {
                return Resources.earth;
            }

            if (number == 3)
            {
                return Resources.planet;
            }

            if (number == 4)
            {
                return Resources.sat;
            }

            if (number == 5)
            {
                return Resources.star;
            }

            if (number == 6)
            {
                return Resources.stars2;
            }

            if (number == 7)
            {
                return Resources.ufo;
            }

            return Resources.ufo;
        }
    }
}