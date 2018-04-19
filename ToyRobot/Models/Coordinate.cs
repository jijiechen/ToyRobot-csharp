namespace ToyRobot.Models
{
    public struct Coordinate
    {
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public static Coordinate Invalid = new Coordinate(-1, -1);
        
        public int X { get; }
        public int Y { get; }
    }
}