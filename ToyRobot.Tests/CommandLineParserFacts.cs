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
        
    }
}