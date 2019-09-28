using System;

namespace Viu
{
    public interface IActionable : IFocusable
    {
        event EventHandler<ActionEventArgs> ActionOnComponent;
    }
}