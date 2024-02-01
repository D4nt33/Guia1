using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploUno
{
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
            string texto = txtnombre.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto);
            ventana2 frmrecibe = new ventana2(mensaje); /* creo un objeto del segundo formulario,
            adonde mando información*/
            frmrecibe.Visible = true; // muestra el nuevo formulario
            this.Visible = false; // esconde el formulario actual


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); //termina la aplicación
        }
    }
}
