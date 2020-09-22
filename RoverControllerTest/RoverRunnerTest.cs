using RoverController;
using Xunit;

namespace RoverControllerTest
{
    public class RoverRunnerTest
    {
        [Fact]
        public void Test_Run_Should_Move_To_13N_When_Given_Input()
        {
            //Given 
            RoverRunner roverRunner = new RoverRunner();
            roverRunner.Add(RoverFactory.Create(1, 2, 'N', "Rover", new Plateau(5, 5)), "LMLMLMLMM");

            //When
            var result = roverRunner.Run();

            //Then
            Assert.Equal("1 3 N", result[0]);
        }

        [Fact]
        public void Test_Run_Should_Move_To_51E_When_Given_Input()
        {
            //Given 
            RoverRunner roverRunner = new RoverRunner();
            roverRunner.Add(RoverFactory.Create(3, 3, 'E', "Rover", new Plateau(5, 5)), "MMRMMRMRRM");

            //When
            var result = roverRunner.Run();

            //Then
            Assert.Equal("5 1 E", result[0]);
        }

        [Fact]
        public void Test_Run_Should_Move_To_15N_When_Given_Input()
        {
            //Given 
            RoverRunner roverRunner = new RoverRunner();
            roverRunner.Add(RoverFactory.Create(1, 2, 'N', "Rover", new Plateau(5, 5)), "LMLMLMLMMMMM");

            //When
            var result = roverRunner.Run();

            //Then
            Assert.Equal("1 5 N", result[0]);
        }

        [Fact]
        public void Test_Run_Should_Move_All_Rovers_Sequentially_When_Given_Input()
        {
            //Given 
            RoverRunner roverRunner = new RoverRunner();
            roverRunner.Add(RoverFactory.Create(1, 2, 'N', "Rover-1", new Plateau(5, 5)), "LMLMLMLMM");
            roverRunner.Add(RoverFactory.Create(3, 3, 'E', "Rover-2", new Plateau(5, 5)), "MMRMMRMRRM");

            //When
            var result = roverRunner.Run();

            //Then
            Assert.Equal("1 3 N", result[0]);
            Assert.Equal("5 1 E", result[1]);
        }


        [Fact]
        public void Test_Run_Should_Cant_Move_When_Given_Input()
        {
            //Given 
            RoverRunner roverRunner = new RoverRunner();
            roverRunner.Add(RoverFactory.Create(0, 0, 'N', "Rover", new Plateau(0, 0)), "LMLMLMLMM");

            //When
            var result = roverRunner.Run();

            //Then
            Assert.Equal("0 0 N", result[0]);
        }
    }
}
