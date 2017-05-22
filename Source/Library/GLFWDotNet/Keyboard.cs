using System;

namespace GLFWDotNet
{
    public partial class Keyboard : IDisposable
    {
        private readonly Window window;

        public bool this[Keys key] => this.keyMap[this.GetKeyMapIndex(key)];

        public Keyboard(Window window)
        {
            this.window = window ?? throw new ArgumentNullException(nameof(window));
            this.window.KeyAction += this.Window_KeyAction;
        }
        
        public void Dispose()
        {
            this.window.KeyAction -= this.Window_KeyAction;
        }

        private void Window_KeyAction(object sender, KeyActionEventArgs e)
        {
            int index = this.GetKeyMapIndex(e.Key);

            if (e.Action == InputAction.Release)
            {
                this.keyMap[index] = false;
            }
            else
            {
                this.keyMap[index] = true;
            }
        }
    }
}
