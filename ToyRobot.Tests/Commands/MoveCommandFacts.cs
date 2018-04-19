using ToyRobot.Commands;
using ToyRobot.Models;
using Xunit;

namespace ToyRobot.Tests.Commands
{
    public class MoveCommandFacts
    {
        [Theory]
        [InlineData("MOVE", true)]
        [InlineData("move", false)]
        [InlineData("mv", false)]
        public void ShouldParseCommand(string commandline, bool shouldParse)
        {
            var command = MoveCommand.Parse(commandline);

            if (shouldParse)
            {
                Assert.NotNull(command);
            }
            else
            {
                Assert.Null(command);
            }
        }
        
        

        [Fact]
        public void ShouldMoveNorth()
        {
            var robot = new Robot();
            robot.PlaceAt(new Coordinate(2,3), Direction.North);

            new MoveCommand().Execute(robot);
            
            Assert.Equal(Direction.North, robot.Direction);
            Assert.Equal(2, robot.Coordinate.X);
            Assert.Equal(4, robot.Coordinate.Y);
        }
        
        
        [Fact]
        public void ShouldNotMoveInvalidRobot()
        {
            var robot = new Robot();
            
            new MoveCommand().Execute(robot);
            
            Assert.Equal(Direction.Invalid, robot.Direction);
            Assert.Equal(Coordinate.Invalid, robot.Coordinate);
        }
        
        
    }
}