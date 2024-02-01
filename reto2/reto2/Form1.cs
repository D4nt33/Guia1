using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            double a, b, c;
            if (!double.TryParse(txta.Text, out a) ||
                !double.TryParse(txtb.Text, out b) ||
                !double.TryParse(txtc.Text, out c))
            {
                MessageBox.Show("Ingrese valores numéricos válidos para a, b y c.");
                return;
            }

            // Calcular el discriminante
            double discriminante = Math.Pow(b, 2) - 4 * a * c;

            // Calcular las soluciones
            if (discriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);

                // Mostrar las soluciones en los TextBox correspondientes
                txtxu.Text = x1.ToString();
                txtd.Text = x2.ToString();
                lblMensaje.Text = "Dos soluciones reales.";
            }
            else if (discriminante == 0)
            {
                double x = -b / (2 * a);

                // Mostrar la solución única en los TextBox correspondientes
                txtxu.Text = x.ToString();
                txtd.Text = x.ToString();
                lblMensaje.Text = "Una solución real (doble raíz).";
            }
            else
            {
                // Mostrar un mensaje indicando que no hay soluciones reales
                txtxu.Text = string.Empty;
                txtd.Text = string.Empty;
                lblMensaje.Text = "No hay soluciones reales.";
            }
        }
    }
}
    

