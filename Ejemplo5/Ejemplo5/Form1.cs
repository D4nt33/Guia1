using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            listbox.Items.Add(txtingresar.Text);
            txtingresar.Clear();
            txtingresar.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                string valor = listbox.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        txt1.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txt1.Text = "No hay números negativos pares";
                }
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = listbox.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                string valor = listbox.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txt2.Text = porcentaje.ToString() + "%";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                string valor = listbox.Items[i].ToString();
                int numero = int.Parse(valor);
            
            if(numero > 0 && numero % 2 != 0)
 {
                suma = suma + numero;
                cantidadimpares = cantidadimpares + 1;
            }
        }
        prom = suma / cantidadimpares;
        txt3.Text = prom.ToString();

    }

        private void btn4_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listbox.Items.Count; i++)
            {
                string valor = listbox.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            txt4.Text = mayor.ToString();
        }
    }
}
