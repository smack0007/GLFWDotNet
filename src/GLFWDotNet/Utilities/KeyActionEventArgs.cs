using System;

namespace GLFWDotNet.Utilities
{
    public class KeyActionEventArgs : EventArgs
    {
        public Keys Key { get; internal set; }

        public int ScanCode { get; internal set; }

        public InputActions Action { get; internal set; }

        public KeyModifiers Modifiers { get; internal set; }

        internal KeyActionEventArgs()
        {
        }
    }
}
