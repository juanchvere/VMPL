using Presentador;
using System;
using System.Windows.Forms;

namespace launcher1
{
    class Launcher
    {
       
        private Modelo miApp;
        
        public Launcher()
        {
           
            miApp = new Modelo();
            miApp.iniciar();
        }
        
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            Application.EnableVisualStyles();
            new Launcher();
            //Console.ReadLine();
            

            //Console.WriteLine("Hello World!");
        }

    }
}
