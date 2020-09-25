using System;
using System.IO;
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

        private static class Linux
        {

            const int RTLD_NOW = 2;
            public static IntPtr LoadLibrary (string fileName)
            {
                IntPtr retVal = dlopen (fileName, RTLD_NOW);
                var errPtr = dlerror ();
                if (errPtr != IntPtr.Zero) {
                    Console.WriteLine(Marshal.PtrToStringAnsi (errPtr));
                }
                return retVal;
            }

            public static void FreeLibrary (IntPtr handle)
            {
                dlclose (handle);
            }

            [DllImport("libdl.so")]
            private static extern IntPtr dlopen (String fileName, int flags);

            [DllImport("libdl.so")]
            public static extern IntPtr dlsym (IntPtr handle, String symbol);

            [DllImport("libdl.so")]
            private static extern int dlclose (IntPtr handle);

            [DllImport("libdl.so")]
            private static extern IntPtr dlerror ();
        }

        public static class OSX
        {
            const int RTLD_NOW = 2;
            public static IntPtr LoadLibrary(string fileName)
            {
                IntPtr retVal = dlopen(fileName, RTLD_NOW);
                var errPtr = dlerror();
                if (errPtr != IntPtr.Zero)
                {
                    Console.WriteLine(Marshal.PtrToStringAnsi(errPtr));
                }

                return retVal;
            }

            public static void FreeLibrary(IntPtr handle)
            {
                dlclose(handle);
            }


            [DllImport("libdl.dylib")]
            private static extern IntPtr dlopen(String fileName, int flags);

            [DllImport("libdl.dylib")]
            public static extern IntPtr dlsym(IntPtr handle, String symbol);

            [DllImport("libdl.dylib")]
            private static extern int dlclose(IntPtr handle);

            [DllImport("libdl.dylib")]
            private static extern IntPtr dlerror();
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
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) )
            {
                // sudo apt install libglfw3-dev
                string assemblyPath = "libglfw.so";
                IntPtr assembly = Linux.LoadLibrary(assemblyPath);
                if (assembly == IntPtr.Zero)
                    throw new InvalidOperationException($"Failed to load GLFW so from path '{assemblyPath}'.");

                return functionName => Linux.dlsym(assembly, functionName);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // brew install glfw3
                string assemblyPath = "libglfw.dylib";
                IntPtr assembly = OSX.LoadLibrary(assemblyPath);
                if (assembly == IntPtr.Zero)
                    throw new InvalidOperationException($"Failed to load GLFW dylib from path '{assemblyPath}'.");

                return functionName => OSX.dlsym(assembly, functionName);
            }

            throw new NotImplementedException("Unsupported platform.");
        }
    }
}
