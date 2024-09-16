using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculadora_IMC
{
    public partial class frmcalcImc : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

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

            lblImcDisplay.Text = calculo.ToString("F1");

            if (calculo <= 18.4)
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
                lblRankDisplay.Text = "Sobrepeso";
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
            frmMenuPrincipal open = new frmMenuPrincipal();
            open.Show();
            this.Hide();
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
            if(txtAltura.Text == "")
            {
                txtAltura.Text = "1";
            }

            double altura = Convert.ToDouble(txtAltura.Text);

            if(altura >= 2.50 || altura <= 0)
            {
                MessageBox.Show("Altura não pode ser maior que 2,50 metros ou menor que zero. \r\n Verifique a posição da vírgula.", "Calculadora IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            lblRankDisplay.Visible = false;
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (txtPeso.Text == "")
            {
                txtPeso.Text = "1";
            }

            double peso = Convert.ToDouble(txtPeso.Text);

            if (peso >= 200)
            {
                MessageBox.Show("Peso não pode ser maior que 200Kg.", "Calculadora IMC",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void frmcalcImc_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void txtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPeso.Focus();
            }
        }

        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }
    }
}
