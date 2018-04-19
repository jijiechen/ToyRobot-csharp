using Xunit;

namespace ToyRobot.Tests
{
    public class ReportCommandFacts
    {
        [Fact]
        public void ShouldParseReportCommand()
        {
            var command = ReportCommand.Parse("");
            
            Assert.NotNull(command);   
        }
    }
}