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
    public partial class frmcalcImc : Form
    {
        public frmcalcImc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double altura, peso;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            Double calculo = peso / (altura * altura);

            lblImcDisplay.Text = Convert.ToString(calculo);

            if(calculo <= 18.4)
            {
                lblRankDisplay.Text = "Abaixo do peso";
                lblRankDisplay.Visible = true;
            }
            else if(calculo <= 24.9)
            {
                lblRankDisplay.Text = "Peso normal";
                lblRankDisplay.Visible = true;
            }
            else if(calculo <= 29.9)
            {
                lblRankDisplay.Text = "Acima do peso";
                lblRankDisplay.Visible = true;
            }
            else if(calculo <= 34.9)
            {
                lblRankDisplay.Text = "Obesidade Grau 1";
                lblRankDisplay.Visible = true;
            }
            else if(calculo <= 39.9)
            {
                lblRankDisplay.Text = "Obesidade Grau 2";
                lblRankDisplay.Visible = true;
            }
            else if(calculo >= 40)
            {
                lblRankDisplay.Text = "Obesidade Grau 3";
                lblRankDisplay.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtAltura_Leave(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            
            if(altura >= 2.50 || altura <= 0)
            {
                MessageBox.Show("Altura não pode ser maior que 2,50 metros. \r\n Verifique a posição da vírgula.", "Calculadora IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
