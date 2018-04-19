using Xunit;

namespace ToyRobot.Tests
{
    public class ReportCommandFacts
    {
        [Fact]
        public void ShouldParseReportCommand()
        {
            var command = ReportCommand.Parse("REPORT");
            
            Assert.NotNull(command);   
        }
    }
}