using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador
{
    
    public class ControlVista
    {
        private Vista ventanaPrincipal;
        private Modelo modelo;

        public ControlVista(Vista ventana)
        {
            this.ventanaPrincipal = ventana;
            modelo = ventana.getModelo();
        }

        public Modelo getModelo()
        {
            return modelo;
        }
    }
}
