using System;
using GLDotNet;
using static GLFWDotNet.GLFW;

namespace GLFWDotNet.Samples
{
    public class GLFWPlatformContext : IGLPlatformContext
    {
        public IntPtr Window { get; }

        public int VersionMajor { get; }

        public int VersionMinor { get; }

        public GLFWPlatformContext(IntPtr window, int versionMajor, int versionMinor)
        {
            this.Window = window;
            this.VersionMajor = versionMajor;
            this.VersionMinor = versionMinor;
        }

        public void Dispose()
        {
        }

        public IntPtr GetProcAddress(string name)
        {
            return glfwGetProcAddress(name);
        }

        public void MakeCurrent()
        {
            glfwMakeContextCurrent(this.Window);
        }

        public void SwapBuffers()
        {
            glfwSwapBuffers(this.Window);
        }
    }
}
