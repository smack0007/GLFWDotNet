using System;

namespace GLFWDotNet.Utilities
{
    public class Mouse : IDisposable
    {
        private readonly Window window;

        public double X { get; private set; }

        public double Y { get; private set; }

        public Mouse(Window window)
        {
            this.window = window ?? throw new ArgumentNullException(nameof(window));
            this.window.MousePositionChanged += this.Window_MousePositionChanged;
        }

        public void Dispose()
        {
            this.window.MousePositionChanged -= this.Window_MousePositionChanged;
        }

        private void Window_MousePositionChanged(object sender, MousePositionEventArgs e)
        {
            X = e.XPosition;
            Y = e.YPosition;
        }
    }
}
