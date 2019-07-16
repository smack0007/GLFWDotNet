using GLFWDotNet.Utilities;
using System;

namespace HelloWorldUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            var window = new MainWindow();
            window.MakeContextCurrent();

            var keyboard = new Keyboard(window);
            var mouse = new Mouse(window);

            Application.Run(window, () =>
            {
                if (keyboard[Keys.Escape])
                {
                    window.Close();
                }

                window.Info = $"Mouse: ({mouse.X}, {mouse.Y})";
            });

            Application.Terminate();
        }
    }
}
