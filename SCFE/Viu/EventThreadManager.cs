using System;

namespace Viu
{
    public interface IEventThreadManager
    {
        void DoGraphicsLater(Action<GraphicsContext> action);

        void DoGraphicsAndWait(Action<GraphicsContext> action);
    }
}