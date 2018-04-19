using System;
using System.Text.RegularExpressions;

namespace ToyRobot
{
    public class PlaceCommand : ICommand
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public static PlaceCommand Parse(string input)
        {
            var prefix = "PLACE ";
            if (!input.StartsWith(prefix))
            {
                return null;
            }

            input = input.Substring(prefix.Length);
            var pattern = new Regex(@"(?<x>\d),(?<y>\d),(?<direction>NORTH|SOUTH|EAST|WEST)", RegexOptions.Compiled);
            var match = pattern.Match(input);
            if (!match.Success)
            {
                return null;
            }

            return new PlaceCommand
            {
                X = int.Parse(match.Groups["x"].Value),
                Y = int.Parse(match.Groups["y"].Value),
                Direction = Enum.Parse<Direction>(
                    match.Groups["direction"].Value, 
                    ignoreCase: true)
            };
        }
    }
}