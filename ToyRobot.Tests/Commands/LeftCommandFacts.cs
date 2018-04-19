using ToyRobot.Commands;
using ToyRobot.Models;
using Xunit;

namespace ToyRobot.Tests.Commands
{
    public class LeftCommandFacts
    {
        [Theory]
        [InlineData("LEFT", true)]
        [InlineData("left", false)]
        [InlineData("lf", false)]
        public void ShouldParseCommand(string commandline, bool shouldParse)
        {
            var command = LeftCommand.Parse(commandline);

            if (shouldParse)
            {
                Assert.NotNull(command);
            }
            else
            {
                Assert.Null(command);
            }
        }
        
        
        [Theory]
        [InlineData(Direction.East, Direction.North)]
        [InlineData(Direction.West, Direction.South)]
        [InlineData(Direction.North, Direction.West)]
        [InlineData(Direction.South, Direction.East)]
        public void ShouldTurnLeftAndKeepCoordinate(Direction before, Direction after)
        {
            var robot = new Robot();
            robot.PlaceAt(new Coordinate(1, 1), before);
            
            var command = new LeftCommand();
            command.Execute(robot);
            
            Assert.Equal(after, robot.Direction);
            Assert.Equal(1, robot.Coordinate.X);
            Assert.Equal(1, robot.Coordinate.Y);
        }
        
        
        [Fact]
        public void ShouldNotTurnInvalidRobot()
        {
            var robot = new Robot();
            
            var command = new LeftCommand();
            command.Execute(robot);
            
            Assert.Equal(Direction.Invalid, robot.Direction);
            Assert.Equal(Coordinate.Invalid, robot.Coordinate);
        }
        
    }
}