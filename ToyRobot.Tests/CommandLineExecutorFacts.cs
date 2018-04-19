using System;
using System.IO;
using System.Text;
using Xunit;

namespace ToyRobot.Tests
{
    public class CommandLineExecutorFacts
    {
        [Fact]
        public void ShouldExecutePlaceBySpecifiedInputAndOutput()
        {
            var commandLine = "PLACE 1,2,NORTH";
            var input = new StringReader(commandLine);
            var output = new StringWriter();

            CommandLineExecutor.Execute(input, output);
        }
        
        [Fact]
        public void ShouldExecuteMultipleLinesBySpecifiedInputAndOutput()
        {
            var commandLine = String.Join(Environment.NewLine,
                "PLACE 1,2,NORTH",
                "REPORT");
            
            var input = new StringReader(commandLine);
            var outputContent = new StringBuilder();
            var output = new StringWriter(outputContent);

            CommandLineExecutor.Execute(input, output);
            
            Assert.Equal("1,2,NORTH" + Environment.NewLine, outputContent.ToString());
        }
    }
}