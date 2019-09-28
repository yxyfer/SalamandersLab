namespace Viu
{
    public interface ICursorFocusable : IFocusable
    {
        /// <summary>
        ///     Called after all print events, including when the component is NOT focused. Sets the cursor to the position where
        ///     it
        ///     needs to be displayed, as well as making it visible if necessary or adjusting any other thing about the component.
        /// </summary>
        void UpdateCursorState(GraphicsContext g);
    }
}