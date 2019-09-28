using System;

namespace Viu
{
    public interface IFocusable
    {
        /// <summary>
        ///     Handle a key press. This is only called if the IsFocusable method returned true upon a user input.
        /// </summary>
        /// <param name="keyPressed">The key that was pressed</param>
        /// <param name="g"></param>
        /// <returns>Whether the key event was consumed ("accepted") or not. If not it will be passed to a focusable child.</returns>
        bool AcceptInput(ConsoleKeyInfo keyPressed, GraphicsContext g);

        bool IsFocusable();

        void SetFocused(bool focused, GraphicsContext g);

        bool IsFocused();
    }
}