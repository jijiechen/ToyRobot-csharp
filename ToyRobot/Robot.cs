﻿using System;

namespace ToyRobot
{
    public class Robot
    {
        private readonly Table _table;

        public Robot() : this(new Table(5, 5)){ }
        
        public Robot(Table table)
        {
            _table = table;
        }

        public Coordinate Coordinate { get; private set; } = Coordinate.Invalid;
        public Direction Direction { get; private set; } = Direction.Invalid;

        public void PlaceAt(Coordinate coordinate, Direction direction)
        {
            if (coordinate.X + 1 > _table.Width || coordinate.Y + 1 > _table.Height)
            {
                return;
            }
            
            this.Coordinate = coordinate;
            this.Direction = direction;
        }
    }
}