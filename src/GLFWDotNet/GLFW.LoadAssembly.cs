using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace GLFWDotNet
{
    public static partial class GLFW
    {
        private static class Win32
        {
            [DllImport("kernel32")]
            public static extern IntPtr LoadLibrary(string fileName);

            [DllImport("kernel32")]
            public static extern IntPtr GetProcAddress(IntPtr module, string procName);
        }

        private static Func<string, IntPtr> LoadAssembly()
        {
            var assemblyDirectory = Path.GetDirectoryName(typeof(GLFW).Assembly.Location);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                string assemblyPath = Path.Combine(
                    assemblyDirectory,
                    "runtimes",
                    Environment.Is64BitProcess ? "win-x64" : "win-x86",
                    "native",
                    "glfw3.dll");

                IntPtr assembly = Win32.LoadLibrary(assemblyPath);

                if (assembly == IntPtr.Zero)
                    throw new InvalidOperationException($"Failed to load GLFW dll from path '{assemblyPath}'.");

                return x => Win32.GetProcAddress(assembly, x);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Coming soon...
            }

            throw new NotImplementedException("Unsupported platform.");
        }
    }
}
