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
        
        [Fact]
        public void ShouldHandleReportCommand()
        {
            var command = new ReportCommand();

            var robot = new Robot();
            robot.PlaceAt(new Coordinate(1, 2), Direction.North);
            var robotOperator = new RobotOperator(robot);
            var result = robotOperator.HandleCommand(command);
            
            Assert.Equal("1,2,North", result);
        }
        
        
        [Fact]
        public void ShouldHandleReportAndOutputNothingForInvalidRobots()
        {
            var command = new ReportCommand();

            var robot = new Robot();
            var robotOperator = new RobotOperator(robot);
            var result = robotOperator.HandleCommand(command);
            
            Assert.Equal(string.Empty, result);
        }
    }
}