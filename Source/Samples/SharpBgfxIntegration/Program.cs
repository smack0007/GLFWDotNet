using System;
using System.Runtime.InteropServices;
using GLFWDotNet;
using SharpBgfx;

namespace SharpBgfxIntegration
{
    public class Program
    {
        [DllImport("glfw3", EntryPoint = "glfwGetWin32Window", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr GetWin32Window(IntPtr window);

        public static int Main(string[] args)
        {
            if (GLFW.Init() == 0)
                return -1;

            GLFW.WindowHint(GLFW.CLIENT_API, GLFW.NO_API);
            
            string title = $"GLFW & SharpBgfx";

            IntPtr window = GLFW.CreateWindow(640, 480, title, IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                GLFW.Terminate();
                return -1;
            }

            Bgfx.SetPlatformData(new PlatformData()
            {
                WindowHandle = GetWin32Window(window)
            });

            Bgfx.Init();

            Bgfx.Reset(640, 480, ResetFlags.Vsync);

            Bgfx.SetDebugFeatures(DebugFeatures.DisplayText);

            Bgfx.SetViewClear(0, ClearTargets.Color | ClearTargets.Depth, 0x303030ff);

            while (GLFW.WindowShouldClose(window) == 0)
            {
                GLFW.PollEvents();

                Bgfx.Touch(0);

                // write some debug text
                Bgfx.DebugTextClear();
                Bgfx.DebugTextWrite(0, 1, DebugColor.White, DebugColor.Blue, "GLFWDotNet & SharpBgfx");
                Bgfx.DebugTextWrite(0, 2, DebugColor.White, DebugColor.Cyan, "Description: Initialization and debug text.");

                // advance to the next frame. Rendering thread will be kicked to
                // process submitted rendering primitives.
                Bgfx.Frame();

                GLFW.SwapBuffers(window);
            }

            Bgfx.Shutdown();
            
            GLFW.Terminate();

            return 0;
        }
    }
}
