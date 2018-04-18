using Xunit;

namespace ToyRobot.Tests
{
    public class RobotFacts
    {
        [Fact]
        public void ShouldInitializeRobotOnTable()
        {
            var robot = new Robot();

            Assert.Equal(Coordinate.Invalid, robot.Coordinate);
            Assert.Equal(Direction.Invalid, robot.Direction);
        }
        
        [Fact]
        public void ShouldAcceptPlaceCommand()
        {
            var robot = new Robot();

            robot.PlaceAt(new Coordinate(1, 2), Direction.North);
            
            Assert.Equal(1, robot.Coordinate.X);
            Assert.Equal(2, robot.Coordinate.Y);
            Assert.Equal(Direction.North, robot.Direction);
        }
        
        
        [InlineData(0, 0, true)]
        [InlineData(4, 4, true)]
        [InlineData(0, 4, true)]
        [InlineData(4, 0, true)]
        [InlineData(0, 5, false)]
        [InlineData(5, 0, false)]
        [InlineData(5, 5, false)]
        [InlineData(-1, 1, false)]
        [InlineData(1, -1, false)]
        [Theory]
        public void ShouldNotAcceptCoordinateOutOfTable(int x, int y, bool isValid)
        {
            var table = new Table(5, 5);
            var robot = new Robot(table);

            robot.PlaceAt(new Coordinate(x, y), Direction.North);

            if (isValid)
            {
                Assert.Equal(new Coordinate(x, y), robot.Coordinate);
            }
            else
            {
                Assert.Equal(Coordinate.Invalid, robot.Coordinate);
            }
        }
        

    }
}
