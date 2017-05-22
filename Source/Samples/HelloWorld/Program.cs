using System;
using GLDotNet;
using GLFWDotNet;
using GLFWDotNet.Samples;

namespace HelloWorld
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (GLFW.Init() == 0)
                return -1;

            GLFW.GetVersion(out int major, out int minor, out int revision);
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

            GL gl = new GL(new GLFWPlatformContext(window, 4, 0));

            var versionString = gl.GetString(StringName.Version);
            var rendererString = gl.GetString(StringName.Renderer);

            GLFW.SetWindowTitle(window, $"{title} {versionString} {rendererString}");

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
