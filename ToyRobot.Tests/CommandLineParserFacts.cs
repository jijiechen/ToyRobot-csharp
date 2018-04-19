using ToyRobot.Commands;
using Xunit;

namespace ToyRobot.Tests
{
    public class CommandLineParserFacts
    {
        [Fact]
        public void ShouldParsePlaceCommand()
        {
            var parsedCommand = CommandLineParser.Parse("PLACE 1,2,NORTH");
            
            Assert.IsType<PlaceCommand>(parsedCommand);
        }
        
        [Fact]
        public void ShouldParseReportCommand()
        {
            var parsedCommand = CommandLineParser.Parse("REPORT");
            
            Assert.IsType<ReportCommand>(parsedCommand);
        }
        
        [Fact]
        public void ShouldNotParseNonExistingCommand()
        {
            var parsedCommand = CommandLineParser.Parse("STOP");
            
            Assert.Null(parsedCommand);
        }
       
        
    }
}