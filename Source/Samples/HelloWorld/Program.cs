using System;
using System.Runtime.InteropServices;
using GLFWDotNet;

namespace HelloWorld
{
    public static class Program
    {
        private const uint RENDERER = 0x1F01;
        private const uint VERSION = 0x1F02;

        private delegate IntPtr GetString(uint name);

        public static int Main(string[] args)
        {
            if (GLFW.Init() == 0)
                return -1;

            int major, minor, revision;
            GLFW.GetVersion(out major, out minor, out revision);

            GLFW.WindowHint(GLFW.CLIENT_API, GLFW.OPENGL_API);
            GLFW.WindowHint(GLFW.OPENGL_PROFILE, GLFW.OPENGL_CORE_PROFILE);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MAJOR, 4);
            GLFW.WindowHint(GLFW.CONTEXT_VERSION_MINOR, 0);

            string title = $"Hello World! GLFW {major}.{minor}.{revision}";

            IntPtr window = GLFW.CreateWindow(640, 480, title, IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                GLFW.Terminate();
                return -1;
            }

            GLFW.MakeContextCurrent(window);

            IntPtr proc = GLFW.GetProcAddress("glGetString");
            var getString = (GetString)Marshal.GetDelegateForFunctionPointer(proc, typeof(GetString));
            var versionString = Marshal.PtrToStringAnsi(getString(VERSION));
            var rendererString = Marshal.PtrToStringAnsi(getString(RENDERER));

            GLFW.SetWindowTitle(window, title + " " + versionString + " " + rendererString);

            while (GLFW.WindowShouldClose(window) == 0)
            {
                GLFW.PollEvents();

                GLFW.SwapBuffers(window);
            }

            GLFW.Terminate();
            return 0;
        }
    }
}
