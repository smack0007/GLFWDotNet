using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GLFWDotNet
{
    public static class Application
    {
        private static GLFW.ErrorFun errorCallback = OnError;

        private static void OnError(int error, string description)
        {
            throw new GLFWException(error, description);
        }

        public static bool Init()
        {
            if (GLFW.Init() == 0)
                return false;

            GLFW.SetErrorCallback(errorCallback);

            return true;
        }

        public static void Terminate()
        {
            GLFW.Terminate();
        }

        public static void Run(Window window)
        {
            while (!window.ShouldClose())
            {
                GLFW.PollEvents();
            }
        }
    }
}
