using ToyRobot.Commands;
using ToyRobot.Models;
using Xunit;

namespace ToyRobot.Tests.Commands
{
    public class ReportCommandFacts
    {
        [Fact]
        public void ShouldParseReportCommand()
        {
            var command = ReportCommand.Parse("REPORT");
            
            Assert.NotNull(command);   
        }
        
        
        [Fact]
        public void ShouldExecuteOnValidRobot()
        {
            var command = new ReportCommand();

            var robot = new Robot();
            robot.PlaceAt(new Coordinate(1, 2), Direction.North);
            var result = command.Execute(robot);
            
            Assert.Equal("1,2,NORTH", result);
        }
        
        
        [Fact]
        public void ShouldOutputNullForInvalidRobot()
        {
            var command = new ReportCommand();

            var robot = new Robot();
            var result = command.Execute(robot);
            
            Assert.Null(result);
        }
    }
}