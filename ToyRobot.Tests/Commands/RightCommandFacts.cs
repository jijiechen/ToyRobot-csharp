using ToyRobot.Commands;
using ToyRobot.Models;
using Xunit;

namespace ToyRobot.Tests.Commands
{
    public class RightCommandFacts
    {
        [Theory]
        [InlineData("RIGHT", true)]
        [InlineData("right", false)]
        [InlineData("rt", false)]
        public void ShouldParseCommand(string commandline, bool shouldParse)
        {
            var command = RightCommand.Parse(commandline);

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
        [InlineData(Direction.North, Direction.East)]
        [InlineData(Direction.South, Direction.West)]
        [InlineData(Direction.West, Direction.North)]
        [InlineData(Direction.East, Direction.South)]
        public void ShouldTurnRightAndKeepCoordinate(Direction before, Direction after)
        {
            var robot = new Robot();
            robot.PlaceAt(new Coordinate(1, 1), before);
            
            var command = new RightCommand();
            command.Execute(robot);
            
            Assert.Equal(after, robot.Direction);
            Assert.Equal(1, robot.Coordinate.X);
            Assert.Equal(1, robot.Coordinate.Y);
        }
        
        
        [Fact]
        public void ShouldNotTurnInvalidRobot()
        {
            var robot = new Robot();
            
            var command = new RightCommand();
            command.Execute(robot);
            
            Assert.Equal(Direction.Invalid, robot.Direction);
            Assert.Equal(Coordinate.Invalid, robot.Coordinate);
        }
        
    }
}