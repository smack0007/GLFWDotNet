using System;
using System.Runtime.InteropServices;
using static GLFWDotNet.GLFW;

namespace GLFWDotNet.Utilities
{
    public class Window : IDisposable
    {
        private string _title;
        private int _width, _height;
        private int _x, _y;

        GLFWkeyfun _keyCallback;
        private readonly KeyActionEventArgs _keyActionEventArgs = new KeyActionEventArgs();

        GLFWcursorposfun _cursorPosCallback;
        private readonly MousePositionEventArgs _mousePositionEventArgs = new MousePositionEventArgs();

        GLFWmousebuttonfun _mouseButtonCallback;
        private readonly MouseButtonActionEventArgs _mouseButtonActionEventArgs = new MouseButtonActionEventArgs();

        GLFWwindowsizefun _windowSizeCallback;
        GLFWwindowposfun _windowPosCallback;

        public IntPtr Handle { get; }

        public string Title
        {
            get { return _title; }

            set
            {
                if (value != _title)
                {
                    _title = value;
                    glfwSetWindowTitle(Handle, _title);
                }
            }
        }

        public int Width
        {
            get { return _width; }

            set
            {
                if (value != _width)
                {
                    _width = value;
                    glfwSetWindowSize(Handle, _width, _height);
                }
            }
        }

        public int Height
        {
            get { return _height; }

            set
            {
                if (value != _height)
                {
                    _height = value;
                    glfwSetWindowSize(Handle, _width, _height);
                }
            }
        }

        public int X
        {
            get { return _x; }

            set
            {
                if (value != _x)
                {
                    _x = value;
                    glfwSetWindowPos(Handle, _x, _y);
                }
            }
        }

        public int Y
        {
            get { return _y; }

            set
            {
                if (value != _y)
                {
                    _y = value;
                    glfwSetWindowPos(Handle, _x, _y);
                }
            }
        }

        public event EventHandler<KeyActionEventArgs> KeyAction;

        public event EventHandler<MousePositionEventArgs> MousePositionChanged;

        public event EventHandler<MouseButtonActionEventArgs> MouseButtonAction;
        
        public event EventHandler PositionChanged;

        public event EventHandler SizeChanged;

        public Window()
        {
            _title = string.Empty;
            _width = 800;
            _height = 600;

            Handle = glfwCreateWindow(_width, _height, _title, IntPtr.Zero, IntPtr.Zero);

            if (Handle == IntPtr.Zero)
                throw new GLFWException("Failed to create window.");

            int xpos, ypos;
            glfwGetWindowPos(Handle, out xpos, out ypos);
            _x = xpos;
            _y = ypos;

            _cursorPosCallback = OnCursorPos;
            glfwSetCursorPosCallback(Handle, _cursorPosCallback);

            _mouseButtonCallback = OnMouseButton;
            glfwSetMouseButtonCallback(Handle, _mouseButtonCallback);

            _keyCallback = OnKey;
            glfwSetKeyCallback(Handle, _keyCallback);

            _windowPosCallback = OnWindowPos;
            glfwSetWindowPosCallback(Handle, _windowPosCallback);

            _windowSizeCallback = OnWindowSize;
            glfwSetWindowSizeCallback(Handle, _windowSizeCallback);
        }

        ~Window()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                glfwSetCursorPosCallback(Handle, null);
                _cursorPosCallback = null;

                glfwSetKeyCallback(Handle, null);
                _keyCallback = null;

                glfwSetWindowPosCallback(Handle, null);
                _windowPosCallback = null;

                glfwSetWindowSizeCallback(Handle, null);
                _windowSizeCallback = null;
            }
        }

        public void MakeContextCurrent()
        {
            glfwMakeContextCurrent(Handle);
        }

        public void Close()
        {
            glfwSetWindowShouldClose(Handle, 1);
        }

        public bool ShouldClose()
        {
            return glfwWindowShouldClose(Handle) != 0;
        }

        public IntPtr GetNativeHandle()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return glfwGetWin32Window(Handle);

            return IntPtr.Zero;
        }

        private void OnCursorPos(IntPtr window, double xpos, double ypos)
        {
            OnCursorPositionChanged(xpos, ypos);
        }

        protected virtual void OnCursorPositionChanged(double xPosition, double yPosition)
        {
            _mousePositionEventArgs.XPosition = xPosition;
            _mousePositionEventArgs.YPosition = yPosition;
            MousePositionChanged?.Invoke(this, _mousePositionEventArgs);
        }

        private void OnMouseButton(IntPtr window, int button, int action, int mods)
        {
            OnMouseButtonAction((MouseButtons)button, (InputActions)action, (KeyModifiers)mods);
        }

        protected virtual void OnMouseButtonAction(MouseButtons button, InputActions action, KeyModifiers modifiers)
        {
            _mouseButtonActionEventArgs.Button = button;
            _mouseButtonActionEventArgs.Action = action;
            _mouseButtonActionEventArgs.Modifiers = modifiers;
            MouseButtonAction?.Invoke(this, _mouseButtonActionEventArgs);
        }

        private void OnKey(IntPtr window, int key, int scanCode, int action, int mods)
        {
            OnKeyAction((Keys)key, scanCode, (InputActions)action, (KeyModifiers)mods);
        }

        protected virtual void OnKeyAction(Keys key, int scanCode, InputActions action, KeyModifiers modifiers)
        {
            _keyActionEventArgs.Key = key;
            _keyActionEventArgs.ScanCode = scanCode;
            _keyActionEventArgs.Action = action;
            _keyActionEventArgs.Modifiers = modifiers;
            KeyAction?.Invoke(this, _keyActionEventArgs);
        }

        private void OnWindowSize(IntPtr handle, int width, int height)
        {
            _width = width;
            _height = height;

            OnSizeChanged(EventArgs.Empty);
        }

        protected virtual void OnSizeChanged(EventArgs e)
        {
            SizeChanged?.Invoke(this, e);
        }

        private void OnWindowPos(IntPtr handle, int xpos, int ypos)
        {
            _x = xpos;
            _y = ypos;

            OnPositionChanged(EventArgs.Empty);
        }

        protected virtual void OnPositionChanged(EventArgs e)
        {
            PositionChanged?.Invoke(this, e);
        }
    }
}
