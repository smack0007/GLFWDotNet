﻿using GLFWDotNet.Utilities;
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
            var nativeHandle = window.GetNativeHandle();

            var keyboard = new Keyboard(window);
            var mouse = new Mouse(window);

            Application.Run(window, () =>
            {
                if (keyboard[Keys.Escape])
                {
                    window.Close();
                }

                var mouseButtons = "";

                if (mouse.ButtonLeft)
                    mouseButtons += "L";

                window.Info = $"NativeHandle: {nativeHandle} Mouse: ({mouse.X}, {mouse.Y}) [{mouseButtons}]";
            });

            Application.Terminate();
        }
    }
}
