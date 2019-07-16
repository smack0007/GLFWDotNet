namespace GLFWDotNet.Utilities
{
    public class MousePositionEventArgs
    {
        public double XPosition { get; internal set; }

        public double YPosition { get; internal set; }

        internal MousePositionEventArgs()
        {
        }
    }
}