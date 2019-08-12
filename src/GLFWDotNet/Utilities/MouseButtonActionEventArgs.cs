using System;
using System.Collections.Generic;
using System.Text;

namespace GLFWDotNet.Utilities
{
    public class MouseButtonActionEventArgs : EventArgs
    {
        public MouseButtons Button { get; internal set; }

        public InputActions Action { get; internal set; }

        public KeyModifiers Modifiers { get; internal set; }

        internal MouseButtonActionEventArgs()
        {
        }
    }
}
