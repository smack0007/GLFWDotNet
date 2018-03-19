using System;
using GLDotNet;
using GLFWDotNet.Samples;
using static GLFWDotNet.GLFW;

namespace HelloWorld
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            if (glfwInit() == 0)
                return -1;

            glfwGetVersion(out int major, out int minor, out int revision);
            glfwWindowHint(GLFW_CLIENT_API, GLFW_OPENGL_API);
            glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 4);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 0);

            string title = $"Hello World! GLFW {major}.{minor}.{revision}";

            IntPtr window = glfwCreateWindow(640, 480, title, IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                glfwTerminate();
                return -1;
            }

            glfwMakeContextCurrent(window);

            GL gl = new GL(new GLFWPlatformContext(window, 4, 0));

            var versionString = gl.GetString(StringName.Version);
            var rendererString = gl.GetString(StringName.Renderer);

            glfwSetWindowTitle(window, $"{title} {versionString} {rendererString}");

            while (glfwWindowShouldClose(window) == 0)
            {
                glfwPollEvents();

                glfwSwapBuffers(window);
            }

            glfwTerminate();

            return 0;
        }
    }
}
