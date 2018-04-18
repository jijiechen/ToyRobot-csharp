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
        }
        

    }
}
