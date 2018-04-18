using System;

namespace ToyRobot
{
    public class Robot
    {

        public Coordinate Coordinate { get; private set; } = Coordinate.Invalid;
        public Direction Direction { get; private set; } = Direction.Invalid;

        public void PlaceAt(Coordinate coordinate, Direction direction)
        {
            this.Coordinate = coordinate;
            this.Direction = direction;
        }
    }
}