using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_de_progra_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertirconversoresParcial_Click(object sender, EventArgs e)
        {
            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;

            de = cbodeconversoresParcial.SelectedIndex;
            a = cboaconversoresParcial.SelectedIndex;

            cantidad = double.Parse(txtcantidadconversores.Text);

            double[] Area = { 1, 0.09290304, 0.698896, 0.836127, 437.5, 7000, 10000 };
            respuesta = Area[a] / Area[de] * cantidad;

            lblrespuestasconversores.Text = "Respuesta: " + Math.Round(respuesta, 5);

        }

        private void lblTituloParcial_Click(object sender, EventArgs e)
        {

        }

        private void txtcantidadconversores_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcantidadconveroresParcial_Click(object sender, EventArgs e)
        {

        }

        private void lblrespuestasconversores_Click(object sender, EventArgs e)
        {

        }

        private void cboaconversoresParcial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblaconversores_Click(object sender, EventArgs e)
        {

        }

        private void cbodeconversoresParcial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbldeconversor_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirParcial_Click(object sender, EventArgs e)
        {

        }
    }
}
