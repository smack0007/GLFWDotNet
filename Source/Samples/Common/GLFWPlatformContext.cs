using System;
using GLDotNet;

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
            return GLFW.GetProcAddress(name);
        }

        public void MakeCurrent()
        {
            GLFW.MakeContextCurrent(this.Window);
        }

        public void SwapBuffers()
        {
            GLFW.SwapBuffers(this.Window);
        }
    }
}
