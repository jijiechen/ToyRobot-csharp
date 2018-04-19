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
        
        

        [Theory]
        [InlineData(Direction.North, 2, 4)]
        [InlineData(Direction.South, 2, 2)]
        [InlineData(Direction.West, 1, 3)]
        [InlineData(Direction.East, 3, 3)]
        public void ShouldMoveForwardAndKeepDirection(Direction direction, int expectedX, int expectedY)
        {
            var robot = new Robot(new Table(5, 5));
            robot.PlaceAt(new Coordinate(2,3), direction);

            new MoveCommand().Execute(robot);
            
            Assert.Equal(direction, robot.Direction);
            Assert.Equal(expectedX, robot.Coordinate.X);
            Assert.Equal(expectedY, robot.Coordinate.Y);
        }
        
        
        [Theory]
        [InlineData(2, 4, Direction.North)]
        [InlineData(4, 4, Direction.North)]
        [InlineData(1, 0, Direction.South)]
        [InlineData(4, 0, Direction.South)]
        [InlineData(0, 0, Direction.West)]
        [InlineData(0, 4, Direction.West)]
        [InlineData(4, 1, Direction.East)]
        [InlineData(4, 4, Direction.East)]
        public void ShouldNotMoveOutOfTable(int x, int y, Direction direction)
        {
            var robot = new Robot(new Table(5, 5));
            robot.PlaceAt(new Coordinate(x, y), direction);

            new MoveCommand().Execute(robot);
            
            Assert.Equal(direction, robot.Direction);
            Assert.Equal(x, robot.Coordinate.X);
            Assert.Equal(y, robot.Coordinate.Y);
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