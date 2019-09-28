namespace Viu
{
    public class LineStyle
    {
        public static readonly LineStyle Barebones = new LineStyle('-', '|', '+', '+', '+', '+');
        public static readonly LineStyle Simple = new LineStyle('─', '│', '┌', '┐', '└', '┘');
        public static readonly LineStyle Dotted = new LineStyle('┅', '┇', '┌', '┐', '└', '┘');

        public LineStyle(char horizontal, char vertical, char topLeft, char topRight, char bottomLeft, char bottomRight)
        {
            Horizontal = horizontal;
            Vertical = vertical;
            TopLeft = topLeft;
            TopRight = topRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;
        }

        public char Horizontal { get; }
        public char Vertical { get; }
        public char TopLeft { get; }
        public char TopRight { get; }
        public char BottomLeft { get; }
        public char BottomRight { get; }
    }
}