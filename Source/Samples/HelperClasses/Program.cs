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
