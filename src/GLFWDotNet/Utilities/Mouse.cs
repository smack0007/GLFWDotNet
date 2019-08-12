using System;

namespace GLFWDotNet.Utilities
{
    public class Mouse : IDisposable
    {
        private readonly Window window;

        public double X { get; private set; }

        public double Y { get; private set; }

        public bool ButtonLeft { get; private set; }

        public Mouse(Window window)
        {
            this.window = window ?? throw new ArgumentNullException(nameof(window));
            this.window.MousePositionChanged += Window_MousePositionChanged;
            this.window.MouseButtonAction += Window_MouseButtonAction;
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

        private void Window_MouseButtonAction(object sender, MouseButtonActionEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    ButtonLeft = e.Action == InputActions.Press;
                    break;
            }
        }
    }
}
