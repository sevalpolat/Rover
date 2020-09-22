using System;

namespace RoverController
{
    public class Plateau
    {
        public Tuple<int, int> TopLeft { get; set; }
        public Tuple<int, int> BottomRight { get; set; }
        public Plateau(int x, int y)
        {
            TopLeft = new Tuple<int, int>(0, y);
            BottomRight = new Tuple<int, int>(x, 0);
        }
    }
}
