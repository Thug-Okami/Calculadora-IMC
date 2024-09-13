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
            double salarioBruto, inss, ir, salarioLiquido;

            salarioBruto = Convert.ToDouble(txtSalarioBruto.Text);

        }
    }
}
