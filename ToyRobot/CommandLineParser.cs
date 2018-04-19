

using System;
using System.Collections.Generic;
using System.Linq;
using ToyRobot.Commands;

namespace ToyRobot
{
    public class CommandLineParser
    {
        static IEnumerable<Func<string, ICommand>> commandParsers = new List<Func<string, ICommand>>
        {
            PlaceCommand.Parse,
            ReportCommand.Parse,
            MoveCommand.Parse,
            LeftCommand.Parse,
            RightCommand.Parse
        };

        public static ICommand Parse(string commandLine)
        {
            return commandParsers
                .Select(parser => parser(commandLine))
                .FirstOrDefault(command => command != null);
        }
    }
}