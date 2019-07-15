using GLFWDotNet.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldUtilities
{
    public class MainWindow : Window
    {
        public MainWindow()
            : base()
        {
            this.UpdateTitle();
        }

        private void UpdateTitle()
        {
            this.Title = $"MainWindow [{this.X}x{this.Y}] ({this.Width}x{this.Height})";
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            this.UpdateTitle();
            base.OnSizeChanged(e);
        }

        protected override void OnPositionChanged(EventArgs e)
        {
            this.UpdateTitle();
            base.OnPositionChanged(e);
        }
    }
}
