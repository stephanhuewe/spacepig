using System.Drawing;

namespace Huestel.SpacePig.Logic.Pipe
{
    public class Pipe
    {
        public Pipe(int x, int y, int height, Brush brush)
        {
            X = x;
            Y = y;
            Height = height;
            ColorBrush = brush;
        }


        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public Brush ColorBrush { get; set; }
    }
}
