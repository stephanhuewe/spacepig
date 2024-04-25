using System.Collections.Generic;
using Huestel.SpacePig.Logic.Pipe;

namespace Huestel.SpacePig.Logic.Level
{
    public class Level
    {
        public Level()
        {
            Pipes = new List<PipePair>();
        }

        public List<PipePair> Pipes { get; set; }
        public int LevelNumber { get; set; }
    }
}