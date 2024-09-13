using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_IMC
{
    public partial class frmComb : Form
    {
        public frmComb()
        {
            InitializeComponent();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            double distancia, combPreco, litrosN, precoTotal, eficiencia;

            // Verificar se os campos de texto não estão vazios e contêm valores válidos
            if (double.TryParse(txtDistancia.Text, out distancia) &&
                double.TryParse(txtEficiencia.Text, out eficiencia) &&
                double.TryParse(txtCombPreco.Text, out combPreco))
            {
                // Calcular os valores necessários
                litrosN = distancia / eficiencia;
                precoTotal = combPreco * litrosN;

                // Exibir os resultados nos campos de texto
                txtLitrosN.Text = litrosN.ToString("F1");
                txtPrecoTotal.Text = precoTotal.ToString("F1");
            }
        }

        private void txtEficiencia_TextChanged(object sender, EventArgs e)
        {
            double distancia, combPreco, litrosN, precoTotal, eficiencia;

            // Verificar se os campos de texto não estão vazios e contêm valores válidos
            if (double.TryParse(txtDistancia.Text, out distancia) &&
                double.TryParse(txtEficiencia.Text, out eficiencia) &&
                double.TryParse(txtCombPreco.Text, out combPreco))
            {
                // Calcular os valores necessários
                litrosN = distancia / eficiencia;
                precoTotal = combPreco * litrosN;

                // Exibir os resultados nos campos de texto
                txtLitrosN.Text = litrosN.ToString("F1");
                txtPrecoTotal.Text = precoTotal.ToString("F1");
            }
        }


        private void txtCombPreco_TextChanged(object sender, EventArgs e)
        {
            double distancia, combPreco, litrosN, precoTotal, eficiencia;

            // Verificar se os campos de texto não estão vazios e contêm valores válidos
            if (double.TryParse(txtDistancia.Text, out distancia) &&
                double.TryParse(txtEficiencia.Text, out eficiencia) &&
                double.TryParse(txtCombPreco.Text, out combPreco))
            {
                // Calcular os valores necessários
                litrosN = distancia / eficiencia;
                precoTotal = combPreco * litrosN;

                // Exibir os resultados nos campos de texto
                txtLitrosN.Text = litrosN.ToString("F1");
                txtPrecoTotal.Text = precoTotal.ToString("F1");
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtEficiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtCombPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal open = new frmMenuPrincipal();
            open.Show();
            this.Hide();
        }

        private void frmComb_Load(object sender, EventArgs e)
        {
            txtPrecoTotal.Enabled = false;
            txtLitrosN.Enabled = false;
        }
    }
}
