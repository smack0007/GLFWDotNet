using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLFWDotNet;

namespace HelperClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            MainWindow window = new MainWindow();
            window.MakeContextCurrent();

            Application.Run(window);

            Application.Terminate();
        }
    }
}
