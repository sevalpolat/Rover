using RoverController;
using System;

namespace RoverController
{
    class Program
    {
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau(5, 5);
            RoverRunner roverRunner = new RoverRunner();

            roverRunner.Add(RoverFactory.Create(1, 2, 'N', "Rover-1", plateau), "LMLMLMLMM");
            roverRunner.Add(RoverFactory.Create(3, 3, 'E', "Rover-2", plateau), "MMRMMRMRRM");
            roverRunner.Add(RoverFactory.Create(1, 2, 'N', "Rover-3", plateau), "LMLMLMLMMMMM");

            roverRunner.Run();

            Console.ReadLine();
        }
    }
}
