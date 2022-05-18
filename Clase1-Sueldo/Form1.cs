using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1_Sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double SB = Convert.ToDouble(txtSueldoBruto.Text);
            Impuesto(SB);
        }

        private void Impuesto(double Sueldo)
        {   //Formula para los impuestos.
            double DAFP = Convert.ToDouble(txt_AFP.Text);
            double DISR = Convert.ToDouble(txt_Renta.Text);
            double DSEGURO = Convert.ToDouble(txt_Seguro.Text);
            double AFP, Seguro, Renta, Sueldo_Neto;
            AFP = Sueldo * (DAFP / 100);
            Renta = Sueldo * (DISR / 100);
            Seguro = Sueldo * (DSEGURO / 100);

            Sueldo_Neto = Sueldo - (AFP + Renta + Seguro);

            txtAFPRes.Text = AFP.ToString();
            txtRentaRes.Text = Renta.ToString();
            txtSeguroRes.Text = Seguro.ToString();

            lblResultado.Text = Sueldo_Neto.ToString();
        }
    }
}
