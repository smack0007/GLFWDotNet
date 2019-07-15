using System;
using static GLFWDotNet.GLFW;

namespace GLFWDotNet.Utilities
{
    public class Window : IDisposable
    {
        private string title;
        private int width, height;
        private int x, y;

        GLFWkeyfun keyCallback;
        private readonly KeyActionEventArgs keyActionEventArgs = new KeyActionEventArgs();

        GLFWwindowsizefun windowSizeCallback;
        GLFWwindowposfun windowPosCallback;

        public IntPtr Handle { get; }

        public string Title
        {
            get { return this.title; }

            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    glfwSetWindowTitle(this.Handle, this.title);
                }
            }
        }

        public int Width
        {
            get { return this.width; }

            set
            {
                if (value != this.width)
                {
                    this.width = value;
                    glfwSetWindowSize(this.Handle, this.width, this.height);
                }
            }
        }

        public int Height
        {
            get { return this.height; }

            set
            {
                if (value != this.height)
                {
                    this.height = value;
                    glfwSetWindowSize(this.Handle, this.width, this.height);
                }
            }
        }

        public int X
        {
            get { return this.x; }

            set
            {
                if (value != this.x)
                {
                    this.x = value;
                    glfwSetWindowPos(this.Handle, this.x, this.y);
                }
            }
        }

        public int Y
        {
            get { return this.y; }

            set
            {
                if (value != this.y)
                {
                    this.y = value;
                    glfwSetWindowPos(this.Handle, this.x, this.y);
                }
            }
        }

        public event EventHandler<KeyActionEventArgs> KeyAction;

        public event EventHandler PositionChanged;

        public event EventHandler SizeChanged;

        public Window()
        {
            this.title = string.Empty;
            this.width = 800;
            this.height = 600;

            this.Handle = glfwCreateWindow(this.width, this.height, this.title, IntPtr.Zero, IntPtr.Zero);

            if (this.Handle == IntPtr.Zero)
                throw new GLFWException("Failed to create window.");

            int xpos, ypos;
            glfwGetWindowPos(this.Handle, out xpos, out ypos);
            this.x = xpos;
            this.y = ypos;

            this.keyCallback = this.OnKey;
            glfwSetKeyCallback(this.Handle, this.keyCallback);

            this.windowPosCallback = this.OnWindowPos;
            glfwSetWindowPosCallback(this.Handle, this.windowPosCallback);

            this.windowSizeCallback = this.OnWindowSize;
            glfwSetWindowSizeCallback(this.Handle, this.windowSizeCallback);
        }

        ~Window()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                glfwSetKeyCallback(this.Handle, null);
                this.keyCallback = null;

                glfwSetWindowPosCallback(this.Handle, null);
                this.windowPosCallback = null;

                glfwSetWindowSizeCallback(this.Handle, null);
                this.windowSizeCallback = null;
            }
        }

        public void MakeContextCurrent()
        {
            glfwMakeContextCurrent(this.Handle);
        }

        public void Close()
        {
            glfwSetWindowShouldClose(this.Handle, 1);
        }

        public bool ShouldClose()
        {
            return glfwWindowShouldClose(this.Handle) != 0;
        }

        private void OnKey(IntPtr window, int key, int scanCode, int action, int mods)
        {
            this.OnKeyAction((Keys)key, scanCode, (InputAction)action, (KeyModifiers)mods);
        }

        protected virtual void OnKeyAction(Keys key, int scanCode, InputAction action, KeyModifiers modifiers)
        {
            this.keyActionEventArgs.Key = key;
            this.keyActionEventArgs.ScanCode = scanCode;
            this.keyActionEventArgs.Action = action;
            this.keyActionEventArgs.Modifiers = modifiers;
            this.KeyAction?.Invoke(this, this.keyActionEventArgs);
        }

        private void OnWindowSize(IntPtr handle, int width, int height)
        {
            this.width = width;
            this.height = height;

            this.OnSizeChanged(EventArgs.Empty);
        }

        protected virtual void OnSizeChanged(EventArgs e)
        {
            this.SizeChanged?.Invoke(this, e);
        }

        private void OnWindowPos(IntPtr handle, int xpos, int ypos)
        {
            this.x = xpos;
            this.y = ypos;

            this.OnPositionChanged(EventArgs.Empty);
        }

        protected virtual void OnPositionChanged(EventArgs e)
        {
            this.PositionChanged?.Invoke(this, e);
        }
    }
}
