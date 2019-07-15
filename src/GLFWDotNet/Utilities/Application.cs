using System;
using static GLFWDotNet.GLFW;

namespace GLFWDotNet.Utilities
{
    public static class Application
    {
        private static GLFWerrorfun errorCallback = OnError;

        private static void OnError(int error, string description)
        {
            throw new GLFWException(error, description);
        }

        public static bool Init()
        {
            if (glfwInit() == 0)
                return false;

            glfwSetErrorCallback(errorCallback);

            return true;
        }

        public static void Terminate()
        {
            glfwTerminate();
        }

        public static void Run(Window window, Action idle)
        {
            if (window == null)
                throw new ArgumentNullException(nameof(window));

            if (idle == null)
                throw new ArgumentNullException(nameof(idle));

            while (!window.ShouldClose())
            {
                glfwPollEvents();

                idle();
            }
        }
    }
}
