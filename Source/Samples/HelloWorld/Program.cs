using System;
using GLFWDotNet;

namespace HelloWorld
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (GLFW.Init() == 0)
                return -1;

            int major, minor, revision;
            GLFW.GetVersion(out major, out minor, out revision);

            string title = $"Hello World! GLFW {major}.{minor}.{revision}";

            IntPtr window = GLFW.CreateWindow(640, 480, title, IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                GLFW.Terminate();
                return -1;
            }

            GLFW.MakeContextCurrent(window);

            while (GLFW.WindowShouldClose(window) == 0)
            {
                GLFW.PollEvents();
            }

            GLFW.Terminate();
            return 0;
        }
    }
}
