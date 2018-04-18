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
        
        [Fact]
        public void ShouldNotAcceptCoordinateOutOfTable()
        {
            var table = new Table(5, 5);
            var robot = new Robot(table);

            robot.PlaceAt(new Coordinate(0, 5), Direction.North);
            
            Assert.Equal(Coordinate.Invalid, robot.Coordinate);
        }
        
        

    }
}
