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
    public partial class ventana2 : Form
    {
        public ventana2()
        {
            InitializeComponent();
        }
        public ventana2(string textx)
        {
            InitializeComponent();
            ibmensajed.Text = textx; // Asignamos lo recibido al label
        }
        private void ventana2_Load(object sender, EventArgs e)
        {

        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmventana form1 = new frmventana(); //instanciamos al primer formulario
            this.Close(); //cerramos el formulario actual
            form1.Visible = true; //hacemos visible al form1 de nuevo
        }
    }
}
