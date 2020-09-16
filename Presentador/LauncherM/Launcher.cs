using System;
using Presentador;

namespace LauncherM
{
    class Launcher
    {
        private Modelo miApp;

        public Launcher()
        {
            miApp = new Modelo();
            miApp.iniciar();
        }


        static void Main(string[] args)
        {
            new Launcher();
            //Console.WriteLine("Hello World!");
        }
    }
}
