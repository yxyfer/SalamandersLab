using System.Collections.Generic;

namespace Viu.Components
{
    /// <inheritdoc />
    /// <summary>
    ///     A Container is a Component that has zero or more children Components, which have to be validated and printed.
    ///     Validation is a process that involves setting all of the X, Y, Width and Height values of the container's
    ///     children to their correct value.
    ///     The list of components is not directly accessible, and this class is an abstraction layer for all kinds of
    ///     containers.
    /// </summary>
    public abstract class Container : Component
    {
        protected readonly List<Component> Components = new List<Component>();

        /// <summary>
        ///     If true, the entire area "below" this component is cleared before printing the components.
        ///     Set to false if you wish to use some kind of transparency. Do know that this may lead to incoherent states.
        /// </summary>
        public bool ClearAreaBeforePrint { get; set; }

        public abstract void Validate();

        public override void Print(GraphicsContext g)
        {
            if (!Visible)
                return;

            // Clear the area first
            if (ClearAreaBeforePrint)
                for (var i = Y; i < Height + Y; i++)
                {
                    var s = new string(' ', Width);
                    g.Write(X, i, s);
                }

            foreach (var c in Components)
                if (c.Visible)
                    c.Print(g);
        }
    }
}