using System;
using System.Runtime.InteropServices;
using static GLFWDotNet.GLFW;

namespace HelloWorld
{
    public static class Program
    {
        private const uint GL_COLOR_BUFFER_BIT = 0x00004000;

        private static class Delegates
        {
            public delegate void glClear(uint mask);
            
            public delegate void glClearColor(float red, float green, float blue, float alpha);
        }

        public static int Main(string[] args)
        {
            if (glfwInit() == 0)
                return -1;

            glfwWindowHint(GLFW_CLIENT_API, GLFW_OPENGL_API);
            glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 4);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 0);

            IntPtr window = glfwCreateWindow(640, 480, "Hello World!", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                glfwTerminate();
                return -1;
            }

            glfwMakeContextCurrent(window);

            var glClear = (Delegates.glClear)Marshal.GetDelegateForFunctionPointer(glfwGetProcAddress("glClear"), typeof(Delegates.glClear));
            var glClearColor = (Delegates.glClearColor)Marshal.GetDelegateForFunctionPointer(glfwGetProcAddress("glClearColor"), typeof(Delegates.glClearColor));

            // Cornflower Blue. Never forget.
            glClearColor(100 / 255.0f, 149 / 255.0f, 237 / 255.0f, 1);

            while (glfwWindowShouldClose(window) == 0)
            {
                glfwPollEvents();

                glClear(GL_COLOR_BUFFER_BIT);

                glfwSwapBuffers(window);
            }

            glfwTerminate();

            return 0;
        }
    }
}
