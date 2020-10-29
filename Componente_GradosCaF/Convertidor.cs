using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_GradosCaF;


namespace Componente_GradosCaF
{
    public partial class Convertidor : UserControl
    {
        double cantidad = 0.0;
        double resultado = 0.0;
        double resultado1 = 0.0;

        public Convertidor()
        {
            InitializeComponent();
        }

        private void CelsiusAF_CheckedChanged(object sender, EventArgs e)
        {
            if (CelsiusAF.Checked)
            {
                resultado = Libreria_GradosCaF.Calculos.GradosCaF(cantidad);
             
            }
        }

        private void FahrenheitAC_CheckedChanged(object sender, EventArgs e)
        {
            if (FahrenheitAC.Checked)
            {
                resultado1 = Libreria_GradosCaF.Calculos.GradosFaC(cantidad);

            }
        }

        private void BotonConvertir_Click(object sender, EventArgs e)
        {
            if (CelsiusAF.Checked)
            {
                Resultado.Text = Convert.ToString(resultado);
            }

            if (FahrenheitAC.Checked)
            {
                Resultado.Text = Convert.ToString(resultado1);
            }
        }

        private void CantidadAConvertir_TextChanged(object sender, EventArgs e)
        {
              cantidad = Convert.ToDouble(CantidadAConvertir.Text);
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {
   
        }

    }
}