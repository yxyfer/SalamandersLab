using System;

namespace Viu.Components
{
    public class Separator : Component
    {
        public Orientation Orientation { get; set; } = Orientation.Horizontal;
        public LineStyle Style { get; set; } = LineStyle.Simple;
        public ConsoleColor? Foreground { get; set; } = null;

        public override void Print(GraphicsContext g)
        {
            if (!Visible)
                return;
            if (Orientation == Orientation.Vertical)
            {
                var ch = Style.Vertical;
                for (var y = Y; y < Y + Height; y++) g.Write(X, y, ch + "", Foreground, null);
            }
            else
            {
                var ch = Style.Horizontal;
                g.Write(X, Y, new string(ch, Width), Foreground, null);
            }
        }

        public override Dimensions ComputeDimensions()
        {
            return new Dimensions(1, 1);
        }
    }
}