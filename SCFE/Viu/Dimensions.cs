using Viu.Components;

namespace Viu
{
    public struct Dimensions
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Dimensions(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Dimensions Add(int addW, int addH)
        {
            return new Dimensions(addW + Width, addH + Height);
        }

        public static Dimensions DimensionsOf(Component c)
        {
            return new Dimensions(c.Width, c.Height);
        }
    }
}