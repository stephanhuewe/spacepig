namespace Huestel.SpacePig.Logic.Pipe
{
    public class PipePair
    {
        public PipePair(Pipe upperPipe, Pipe lowerPipe)
        {
            UpperPipe = upperPipe;
            LowerPipe = lowerPipe;
        }

        public Pipe UpperPipe { get; set; }
        public Pipe LowerPipe { get; set; }
    }
}