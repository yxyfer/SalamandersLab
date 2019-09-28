using System;
using JetBrains.Annotations;
using Viu.Components;

namespace Viu
{
    /// <summary>
    ///     Arguments passed for all events related to actions
    /// </summary>
    public class ActionEventArgs : EventArgs
    {
        /// <summary>
        ///     Create the arguments for an action event
        /// </summary>
        /// <param name="component">The component on which the action happened</param>
        /// <param name="sourceKeys">The keys that triggered the action (can be null)</param>
        /// <param name="g">The GraphicsContext subscribers should use to print components</param>
        public ActionEventArgs([CanBeNull] Component component, [CanBeNull] ConsoleKeyInfo? sourceKeys,
            [NotNull] GraphicsContext g)
        {
            Component = component;
            KeySource = sourceKeys;
            Graphics = g;
        }

        /// <summary>
        ///     The component on which the action was performed
        /// </summary>
        [CanBeNull]
        public Component Component { get; }

        /// <summary>
        ///     The source key combination that triggered the action. Can be null if the key combination is not available or
        ///     unknown
        /// </summary>
        [CanBeNull]
        public ConsoleKeyInfo? KeySource { get; }

        /// <summary>
        ///     The GraphicsContext this action should act on.
        /// </summary>
        [NotNull]
        public GraphicsContext Graphics { get; }
    }
}