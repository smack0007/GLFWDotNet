using System;
using System.Linq;
using System.Runtime.InteropServices;
using static GLFWDotNet.GLFW;

namespace GLFWInfo
{
    public static class Program
    {
        private const uint GL_RENDERER = 0x1F01;
        private const uint GL_VERSION = 0x1F02;

        private static class Delegates
        {
            public delegate IntPtr glGetString(uint name);
        }

        public static int Main(string[] args)
        {
            if (glfwInit() == 0)
            {
                Console.Error.WriteLine("Failed to initialize GLFW.");
                return 1;
            }

            glfwGetVersion(out int major, out int minor, out int revision);
            Console.WriteLine($"GLFW Version: {major}.{minor}.{revision}");

            var versionString = glfwGetVersionString();
            Console.WriteLine($"GLFW Version String: {versionString}");

            var monitors = glfwGetMonitors();
            if (monitors != null)
            {
                Console.WriteLine($"Monitor Count: {monitors.Length}");

                foreach (var monitor in monitors)
                {
                    Console.WriteLine($"\t{glfwGetMonitorName(monitor)}");

                    var videoMode = glfwGetVideoMode(monitor);
                    Console.WriteLine($"\t\tVideo Mode: {videoMode.width}x{videoMode.height}");

                    // I don't know that the average gamme ramp value has any use, I just
                    // use it so that I have a number to display. :-p
                    var gammaRamp = glfwGetGammaRamp(monitor);
                    Console.WriteLine($"\t\tGamma Ramp: {nameof(gammaRamp.size)}={gammaRamp.size} {nameof(gammaRamp.red)}={gammaRamp.red.Select(x => (int)x).Average()} {nameof(gammaRamp.green)}={gammaRamp.green.Select(x => (int)x).Average()} {nameof(gammaRamp.blue)}={gammaRamp.blue.Select(x => (int)x).Average()}");
                }
            }

            glfwWindowHint(GLFW_CLIENT_API, GLFW_OPENGL_API);
            glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 4);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 0);
            glfwWindowHint(GLFW_VISIBLE, 0);

            IntPtr window = glfwCreateWindow(1, 1, "", IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                Console.Error.WriteLine("ERROR: Unable to create GL context.");
                glfwTerminate();
                return -1;
            }

            glfwMakeContextCurrent(window);

            var glGetString = Marshal.GetDelegateForFunctionPointer<Delegates.glGetString>(glfwGetProcAddress("glGetString"));

            var version = Marshal.PtrToStringAnsi(glGetString(GL_VERSION));
            Console.WriteLine($"GL Version: {version}");

            var renderer = Marshal.PtrToStringAnsi(glGetString(GL_RENDERER));
            Console.WriteLine($"GL Renderer: {renderer}");

            var vulkanSupported = glfwVulkanSupported();
            Console.WriteLine($"Vulkan supported: {vulkanSupported}");

            var vulkanRequiredInstanceExtensions = glfwGetRequiredInstanceExtensions();
            if (vulkanRequiredInstanceExtensions != null)
            {
                Console.WriteLine("\tRequired Instance Extensions:");
                foreach (var extension in vulkanRequiredInstanceExtensions)
                {
                    Console.WriteLine("\t\t" + extension);
                }
            }

            var joysticks = new int[]
            {
                GLFW_JOYSTICK_1,
                GLFW_JOYSTICK_2,
                GLFW_JOYSTICK_3,
                GLFW_JOYSTICK_4,
                GLFW_JOYSTICK_5,
                GLFW_JOYSTICK_6,
                GLFW_JOYSTICK_7,
                GLFW_JOYSTICK_8,
                GLFW_JOYSTICK_9,
                GLFW_JOYSTICK_10,
                GLFW_JOYSTICK_11,
                GLFW_JOYSTICK_12,
                GLFW_JOYSTICK_13,
                GLFW_JOYSTICK_14,
                GLFW_JOYSTICK_15,
                GLFW_JOYSTICK_16,
            };

            int joystickCount = 0;
            while (glfwJoystickPresent(joysticks[joystickCount]) != 0)
                joystickCount++;

            Console.WriteLine($"Joystick Count: {joystickCount}");

            for (int i = 0; i < joystickCount; i++)
            {
                Console.WriteLine("\t" + glfwGetJoystickName(joysticks[i]));

                var joystickAxes = glfwGetJoystickAxes(joysticks[i]);
                Console.Write("\t\t\tAxes: ");
                foreach (var joystickAxis in joystickAxes)
                    Console.Write(joystickAxis + " ");
                Console.WriteLine();

                var joystickButtons = glfwGetJoystickButtons(joysticks[i]);
                Console.Write("\t\t\tButtons: ");
                foreach (var joystickButton in joystickButtons)
                    Console.Write(joystickButton + " ");
                Console.WriteLine();
            }

            glfwTerminate();

            return 0;
        }
    }
}
