using System;
using System.Collections.Generic;

namespace RoverController
{
    public class RoverRunner
    {
        List<RoverCommandMap> roverCommandMaps = new List<RoverCommandMap>();

        public void Add(IRover rover, string command)
        {
            roverCommandMaps.Add(new RoverCommandMap() { Rover = rover, Command = command });
        }

        public List<string> Run()
        {
            var results = new List<string>();

            foreach (var roverCommand in roverCommandMaps)
            {
                foreach (var item in roverCommand.Command.ToCharArray())
                {
                    switch (item)
                    {
                        case 'L':
                            roverCommand.Rover.TurnLeft();
                            break;
                        case 'R':
                            roverCommand.Rover.TurnRight();
                            break;
                        case 'M':
                            roverCommand.Rover.Move();
                            break;
                    }
                }

                string result = $"{roverCommand.Rover.Position.CoordinateX} {roverCommand.Rover.Position.CoordinateY} {roverCommand.Rover.Position.Compass}";
                results.Add(result);
                Console.WriteLine($"{ roverCommand.Rover.Name}: {result}");
            }

            return results;
        }
    }
}
