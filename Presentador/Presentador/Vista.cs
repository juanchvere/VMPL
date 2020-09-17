using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador
{
    public partial class Vista : Form
    {
        private ControlVista control;
        private Modelo modelo;


        public Vista(Modelo aThis)
        {
            InitializeComponent();
            modelo = aThis;
            capturaEventos();
        }


        public ControlVista getControl()
        {
            if (control == null)
            {
                control = new ControlVista(this);
            }
            return control;
        }

        private void capturaEventos()
        {
            

            /*
             *  TxtValor1.
        lienzo.addMouseListener(getControl());
        btnIniciar.addActionListener(getControl());
        btnDetener.addActionListener(getControl());
        sliVelocidad.addChangeListener(getControl());
        this.addComponentListener(getControl());
        mniNuevo.addActionListener(getControl());
        mniAbrir.addActionListener(getControl());
        mniGuardar.addActionListener(getControl());
        mniPreferencias.addActionListener(getControl());
        mniSalir.addActionListener(getControl());
        mniAcerca.addActionListener(getControl());
            */
        }

        public Modelo getModelo()
        {
            return modelo;
        }

    }
}
