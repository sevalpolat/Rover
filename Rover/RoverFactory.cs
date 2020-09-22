using System;

namespace RoverController
{
    public sealed class RoverFactory 
    {
        public static IRover Create(int x, int y, char compass, string name, Plateau plateau)
        {
            var position = new Position() { CoordinateX = x, CoordinateY = y, Compass = (CompassPoint)Enum.ToObject(typeof(CompassPoint), compass) };

            return new Rover(position, plateau, name);
        }
    }
}
