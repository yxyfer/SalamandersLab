using System;

namespace Viu.Table
{
    public class ListActionEventArgs<T> : EventArgs
    {
        public ListActionEventArgs(IActionable component, ConsoleKeyInfo? sourceKeys, T item, GraphicsContext g)
        {
            Component = component;
            KeySource = sourceKeys;
            Item = item;
            Graphics = g;
        }

        public IActionable Component { get; }

        public ConsoleKeyInfo? KeySource { get; }

        public T Item { get; }

        public GraphicsContext Graphics { get; }
    }
}