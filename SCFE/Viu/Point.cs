using Viu.Components;

namespace Viu
{
    public struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point CenterOf(Point origin, Dimensions dimensions)
        {
            return new Point(origin.X + dimensions.Width / 2, origin.Y + dimensions.Height / 2);
        }

        public static Point CenterOf(Component c)
        {
            return new Point(c.X + c.Width / 2, c.Y + c.Height / 2);
        }

        public Point OriginOf(Component c)
        {
            return new Point(c.X, c.Y);
        }
    }
}