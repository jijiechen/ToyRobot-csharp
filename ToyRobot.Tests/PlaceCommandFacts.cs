using Xunit;

namespace ToyRobot.Tests
{
    public class PlaceCommandFacts
    {
        [Theory]
        [InlineData("PLACE 1,2,NORTH", 1, 2, Direction.North)]
        [InlineData("PLACE 0,5,WEST", 0, 5, Direction.West)]
        [InlineData("PLACE 3,1,EAST", 3, 1, Direction.East)]
        [InlineData("PLACE 0,5,SOUTH", 0, 5, Direction.South)]
        public void ShouldParseCommand(string input, int expectedX, int expectedY, Direction expecteDirection)
        {
            var command = PlaceCommand.Parse(input);
            
            Assert.NotNull(command);
            Assert.Equal(expectedX, command.X);
            Assert.Equal(expectedY, command.Y);
            Assert.Equal(expecteDirection, command.Direction);   
        }
    }
}