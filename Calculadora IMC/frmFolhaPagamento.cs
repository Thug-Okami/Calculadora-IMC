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
    public partial class frmFolhaPagamento : Form
    {
        public frmFolhaPagamento()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal open = new frmMenuPrincipal();
            open.Show();
            this.Hide();
        }

        private void frmFolhaPagamento_Load(object sender, EventArgs e)
        {
            txtInssDemo.Enabled = false;
            txtSBDemo.Enabled = false;
            txtSLDemo.Enabled = false;
            txtIrDemo.Enabled = false;
        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            double salarioBruto, inssTaxa = 0, ir = 0, coopTaxa = 0, salarioLiquido;

            double.TryParse(txtSalarioBruto.Text, out salarioBruto);

                if (salarioBruto <= 1412)
                {
                    inssTaxa = salarioBruto * 0.075;
                }
                else if (salarioBruto <= 2666.68)
                {
                    inssTaxa = salarioBruto * 0.09 - 21.18;
                }
                else if (salarioBruto <= 4000.03)
                {
                    inssTaxa = salarioBruto * 0.12 - 101.18;
                }
                else if (salarioBruto <= 7786.01)
                {
                    inssTaxa = salarioBruto * 0.14 - 181.18;
                }
                else if(salarioBruto >= 7786.02)
                {
                    inssTaxa = 908.86;
                }

                if (salarioBruto <= 2112)
                {
                    ir = 0;
                }
                else if (salarioBruto <= 2826.65)
                {
                    ir = salarioBruto * 0.075;
                }
                else if (salarioBruto <= 4664.68)
                {
                    ir = salarioBruto * 0.225;
                }
                else if (salarioBruto >= 4664.69)
                {
                    ir = salarioBruto * 0.275;
                }

                if (rbtClassA.Checked == true)
                {
                    coopTaxa = salarioBruto * 0.3;
                }
                else if (rbtClassB.Checked == true)
                {
                    coopTaxa = salarioBruto * 0.2;
                }
                else if (rbtClassC.Checked == true)
                {
                    coopTaxa = salarioBruto * 0.1;
                }

                salarioLiquido = salarioBruto - inssTaxa - ir - coopTaxa;

            txtSLDemo.Text = Convert.ToString(salarioLiquido);
            txtIrDemo.Text = Convert.ToString(ir);
            txtSBDemo.Text = txtSalarioBruto.Text;
            txtInssDemo.Text = Convert.ToString(inssTaxa);


        }

    }
}
