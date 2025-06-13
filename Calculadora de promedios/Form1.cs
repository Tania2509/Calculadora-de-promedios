using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_promedios
{
    public partial class frmSistemasDeNotasITR : Form
    {
        public frmSistemasDeNotasITR()
        {
            InitializeComponent();
        }

        private void btnAgregarPromedio_Click(object sender, EventArgs e)
        {
            double nota_uno, nota_dos, nota_tres, promedio;
            if (string.IsNullOrEmpty(txtNotaUno.Text) || string.IsNullOrEmpty(txtNotaDos.Text) || string.IsNullOrEmpty(txtNotaTres.Text) )
            {
                lblError.Text = "Existe un campo vacio \npor favor ingresa el dato que falta ";
            }
            else
            {
                nota_uno = double.Parse(txtNotaUno.Text);
                nota_dos = double.Parse(txtNotaDos.Text);
                nota_tres = double.Parse(txtNotaTres.Text);
                if (nota_uno > 10 || nota_uno<0 || nota_dos >10 || nota_dos < 0 || nota_tres > 10 || nota_tres < 0)
                {
                    lblError.Text = "Por favor ingresa un valor entre 0 y 10";
                }
                else
                {
                    promedio = (nota_uno + nota_dos + nota_tres) / 3;
                    txtPromedio.Text = promedio.ToString("N2");
                    lblError.Text = string.Empty;
                }
            }
            txtNotaUno.ReadOnly = true;
            txtNotaDos.ReadOnly = true;
            txtNotaTres.ReadOnly = true;
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            txtNotaUno.ReadOnly = false;
            txtNotaUno.ReadOnly = false;
            txtNotaTres.ReadOnly = false;

            txtNotaUno.Clear();
            txtNotaDos.Clear();
            txtNotaTres.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
