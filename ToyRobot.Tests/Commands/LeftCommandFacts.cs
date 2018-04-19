using ToyRobot.Commands;
using Xunit;

namespace ToyRobot.Tests.Commands
{
    public class LeftCommandFacts
    {
        [Theory]
        [InlineData("LEFT", true)]
        [InlineData("left", false)]
        [InlineData("lf", false)]
        public void ShouldParseCommand(string commandline, bool shouldParse)
        {
            var command = LeftCommand.Parse(commandline);

            if (shouldParse)
            {
                Assert.NotNull(command);
            }
            else
            {
                Assert.Null(command);
            }
        }
        
        
        
        
    }
}