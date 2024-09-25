using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turnero_Lavadero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSalida.Text = "";

        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            //if "si" else "sino"
            if (txtNombre.Text == "")
            {
                ErrorNombre.SetError(txtNombre, "Debe ingresar su Nombre");
                return;

            }

            else
            {
                ErrorNombre.SetError(txtNombre, "");

            }
            if (txtNumero.Text == "")
            {
                ErrorNumero.SetError(txtNumero, "Debe ingresar su Numero de Telefono");
                return;
            }

            else
            {
                ErrorNumero.SetError(txtNumero, "");
                

            }
            Armarsalida();
            LimpiaTxt();

            
        }
        private void LimpiaTxt()
        {
            ComboxDia.Text = "";
            ComboxHorario.Text = "";
            ComboxLavado.Text = "";
        }
        private string Armarsalida()
        {
            string salida = lblSalida.Text
                + "\r\n"
                + ComboxDia.Text + " - " + ComboxHorario.Text + " - " + ComboxLavado.Text;

            lblSalida.Text = salida;

            return salida;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {






















































































        }
    }

}

