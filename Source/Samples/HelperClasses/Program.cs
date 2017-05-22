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

            Keyboard keyboard = new Keyboard(window);

            Application.Run(window, () =>
            {
                if (keyboard[Keys.Escape])
                {
                    window.Close();
                }
            });

            Application.Terminate();
        }
    }
}
