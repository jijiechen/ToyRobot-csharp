using Xunit;

namespace ToyRobot.Tests
{
    public class RobotOperatorFacts
    {
        [Fact]
        public void ShouldHandlePlaceCommand()
        {
            var command = new PlaceCommand()
            {
                X = 1,
                Y = 2,
                Direction = Direction.North
            };

            var robot = new Robot();
            var robotOperator = new RobotOperator(robot);
            robotOperator.HandleCommand(command);
            
            Assert.Equal(new Coordinate(1, 2), robot.Coordinate);
            Assert.Equal(Direction.North, robot.Direction);
        }
    }
}