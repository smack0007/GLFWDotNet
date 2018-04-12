using System;
using Xunit;
using static GLFWDotNet.GLFW;

namespace GLFWDotNet.Tests
{
    public class GLFWTests : IDisposable
    {
        public GLFWTests()
        {
            if (glfwInit() == 0)
                throw new GLFWInitFailedException();
        }

        public void Dispose()
        {
            glfwTerminate();
        }
    }
}
