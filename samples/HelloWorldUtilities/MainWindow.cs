using GLFWDotNet.Utilities;
using System;

namespace HelloWorldUtilities
{
    public class MainWindow : Window
    {
        private string _info;

        public string Info
        {
            get => _info;

            set
            {
                if (value != _info)
                {
                    _info = value;
                    UpdateTitle();
                }
            }
        }

        public MainWindow()
            : base()
        {
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            Title = $"MainWindow [{X}x{Y}] ({Width}x{Height}) {Info}";
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            UpdateTitle();
            base.OnSizeChanged(e);
        }

        protected override void OnPositionChanged(EventArgs e)
        {
            UpdateTitle();
            base.OnPositionChanged(e);
        }
    }
}
