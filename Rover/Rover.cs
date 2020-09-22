namespace RoverController
{
    public class Rover : IRover
    {
        public string Name { get; }
        public Position Position { get; }
        public Plateau Plateau { get; }

        public Rover(Position position, Plateau plateau, string name)
        {
            Name = name;
            Position = position;
            Plateau = plateau;
        }

        public void TurnLeft()
        {
            switch (Position.Compass)
            {
                case CompassPoint.E:
                    Position.Compass = CompassPoint.N;
                    break;
                case CompassPoint.W:
                    Position.Compass = CompassPoint.S;
                    break;
                case CompassPoint.N:
                    Position.Compass = CompassPoint.W;
                    break;
                case CompassPoint.S:
                    Position.Compass = CompassPoint.E;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Position.Compass)
            {
                case CompassPoint.E:
                    Position.Compass = CompassPoint.S;
                    break;
                case CompassPoint.W:
                    Position.Compass = CompassPoint.N;
                    break;
                case CompassPoint.N:
                    Position.Compass = CompassPoint.E;
                    break;
                case CompassPoint.S:
                    Position.Compass = CompassPoint.W;
                    break;
            }
        }

        public void Move()
        {
            switch (Position.Compass)
            {
                case CompassPoint.E:
                    if ((Position.CoordinateX + 1) <= Plateau.BottomRight.Item1)
                        Position.CoordinateX += 1;
                    break;
                case CompassPoint.W:
                    if ((Position.CoordinateX - 1) >= Plateau.TopLeft.Item1)
                        Position.CoordinateX -= 1;
                    break;
                case CompassPoint.N:
                    if ((Position.CoordinateY + 1) <= Plateau.TopLeft.Item2)
                        Position.CoordinateY += 1;
                    break;
                case CompassPoint.S:
                    if ((Position.CoordinateY - 1) >= Plateau.BottomRight.Item2)
                        Position.CoordinateY -= 1;
                    break;
            }
        }


    }
}
