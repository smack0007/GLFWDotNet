using System;

namespace GLFWDotNet
{
    public class KeyActionEventArgs : EventArgs
    {
        public Keys Key { get; internal set; }

        public int ScanCode { get; internal set; }

        public InputAction Action { get; internal set; }

        public KeyModifiers Modifiers { get; internal set; }

        internal KeyActionEventArgs()
        {
        }
    }
}
