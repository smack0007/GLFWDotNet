using System;

namespace GLFWDotNet
{
    public class Window : IDisposable
    {        
        private string title;
        private int width, height;
        private int x, y;

        GLFW.WindowSizeFun windowSizeCallback;
        GLFW.WindowPosFun windowPosCallback;

        public IntPtr Handle { get; }

        public string Title
        {
            get { return this.title; }

            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    GLFW.SetWindowTitle(this.Handle, this.title);
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
                    GLFW.SetWindowSize(this.Handle, this.width, this.height);
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
                    GLFW.SetWindowSize(this.Handle, this.width, this.height);
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
                    GLFW.SetWindowPos(this.Handle, this.x, this.y);
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
                    GLFW.SetWindowPos(this.Handle, this.x, this.y);
                }
            }
        }

        public event EventHandler SizeChanged;

        public event EventHandler PositionChanged;

        public Window()
        {
            this.title = string.Empty;
            this.width = 800;
            this.height = 600;

            this.Handle = GLFW.CreateWindow(this.width, this.height, this.title, IntPtr.Zero, IntPtr.Zero);

            if (this.Handle == IntPtr.Zero)
                throw new GLFWException("Failed to create window.");

            int xpos, ypos;
            GLFW.GetWindowPos(this.Handle, out xpos, out ypos);
            this.x = xpos;
            this.y = ypos;

            this.windowSizeCallback = this.OnWindowSize;
            GLFW.SetWindowSizeCallback(this.Handle, this.windowSizeCallback);

            this.windowPosCallback = this.OnWindowPos;
            GLFW.SetWindowPosCallback(this.Handle, this.windowPosCallback);
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
                if (this.windowSizeCallback != null)
                {
                    GLFW.SetWindowSizeCallback(this.Handle, null);
                    this.windowSizeCallback = null;
                }
            }
        }

        public void MakeContextCurrent()
        {
            GLFW.MakeContextCurrent(this.Handle);
        }

        public bool ShouldClose()
        {
            return GLFW.WindowShouldClose(this.Handle) != 0;
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
