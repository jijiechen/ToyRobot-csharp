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
        
        [Fact]
        public void ShouldIgnoreCommandsBeforeFirstPlace()
        {
            var commandLine = String.Join(Environment.NewLine,
                "REPORT",
                "MOVE",
                "LEFT",
                "PLACE 1,2,NORTH",
                "MOVE",
                "REPORT");
            
            var input = new StringReader(commandLine);
            var outputContent = new StringBuilder();
            var output = new StringWriter(outputContent);

            CommandLineExecutor.Execute(input, output);
            
            Assert.Equal("1,3,NORTH" + Environment.NewLine, outputContent.ToString());
        }
        
        [Fact]
        public void ShouldIgnoreInvalidCommands()
        {
            var commandLine = String.Join(Environment.NewLine,
                "PLACE 1,2,NORTH",
                "MOVEOUT",
                "REPORT");
            
            var input = new StringReader(commandLine);
            var outputContent = new StringBuilder();
            var output = new StringWriter(outputContent);

            CommandLineExecutor.Execute(input, output);
            
            Assert.Equal("1,2,NORTH" + Environment.NewLine, outputContent.ToString());
        }
        
        [Fact]
        public void ShouldExecuteMoreLinesBySpecifiedInputAndOutput()
        {
            var commandLine = String.Join(Environment.NewLine,
                "PLACE 2,2,NORTH",
                "REPORT",
                "MOVE",
                "LEFT",
                "REPORT",
                "MOVE",
                "REPORT",
                "RIGHT",
                "REPORT");
            
            var input = new StringReader(commandLine);
            var outputContent = new StringBuilder();
            var output = new StringWriter(outputContent);

            
            CommandLineExecutor.Execute(input, output);


            var outputs = new[]
            {
                "2,2,NORTH",
                "2,3,WEST",
                "1,3,WEST",
                "1,3,NORTH"
            };
            var expectedOutput = String.Join(Environment.NewLine, outputs) + Environment.NewLine;
            Assert.Equal(expectedOutput, outputContent.ToString());
        }
    }
}