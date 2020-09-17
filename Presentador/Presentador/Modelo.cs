using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentador
{
    public class Modelo
    {
        private Vista ventanaPrincipal;

        public Vista getVentanaPrincipal()
        {
            if (ventanaPrincipal == null)
            {
                ventanaPrincipal = new Vista(this);
            }
            return ventanaPrincipal;
        }
        public void iniciar()
        {
            //MessageBox.Show("hola");
            //crearNuevoTablero();

            getVentanaPrincipal().Size = new Size(800, 600);
            getVentanaPrincipal().Visible = true;
            getVentanaPrincipal().Show();

        }

    }
}
