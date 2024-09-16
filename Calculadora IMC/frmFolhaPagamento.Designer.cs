
namespace Calculadora_IMC
{
    partial class frmFolhaPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtClassC = new System.Windows.Forms.RadioButton();
            this.rbtClassB = new System.Windows.Forms.RadioButton();
            this.rbtClassA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSLDemo = new System.Windows.Forms.TextBox();
            this.txtIrDemo = new System.Windows.Forms.TextBox();
            this.txtInssDemo = new System.Windows.Forms.TextBox();
            this.txtSBDemo = new System.Windows.Forms.TextBox();
            this.lblSLDemo = new System.Windows.Forms.Label();
            this.lblIrDemo = new System.Windows.Forms.Label();
            this.lblInssDemo = new System.Windows.Forms.Label();
            this.lblSBDemo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(18, 37);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(116, 24);
            this.lblSalarioBruto.TabIndex = 0;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtClassC);
            this.groupBox1.Controls.Add(this.rbtClassB);
            this.groupBox1.Controls.Add(this.rbtClassA);
            this.groupBox1.Location = new System.Drawing.Point(17, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cooperativa";
            // 
            // rbtClassC
            // 
            this.rbtClassC.AutoSize = true;
            this.rbtClassC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtClassC.Location = new System.Drawing.Point(5, 117);
            this.rbtClassC.Name = "rbtClassC";
            this.rbtClassC.Size = new System.Drawing.Size(236, 28);
            this.rbtClassC.TabIndex = 2;
            this.rbtClassC.TabStop = true;
            this.rbtClassC.Text = "Classe C - 10% desconto";
            this.rbtClassC.UseVisualStyleBackColor = true;
            // 
            // rbtClassB
            // 
            this.rbtClassB.AutoSize = true;
            this.rbtClassB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtClassB.Location = new System.Drawing.Point(5, 73);
            this.rbtClassB.Name = "rbtClassB";
            this.rbtClassB.Size = new System.Drawing.Size(235, 28);
            this.rbtClassB.TabIndex = 1;
            this.rbtClassB.TabStop = true;
            this.rbtClassB.Text = "Classe B - 20% desconto";
            this.rbtClassB.UseVisualStyleBackColor = true;
            // 
            // rbtClassA
            // 
            this.rbtClassA.AutoSize = true;
            this.rbtClassA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtClassA.Location = new System.Drawing.Point(5, 29);
            this.rbtClassA.Name = "rbtClassA";
            this.rbtClassA.Size = new System.Drawing.Size(236, 28);
            this.rbtClassA.TabIndex = 0;
            this.rbtClassA.TabStop = true;
            this.rbtClassA.Text = "Classe A - 30% desconto";
            this.rbtClassA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSalarioBruto);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.lblSalarioBruto);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 351);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(22, 74);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(134, 29);
            this.txtSalarioBruto.TabIndex = 4;
            this.txtSalarioBruto.TextChanged += new System.EventHandler(this.txtSalarioBruto_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSLDemo);
            this.groupBox3.Controls.Add(this.txtIrDemo);
            this.groupBox3.Controls.Add(this.txtInssDemo);
            this.groupBox3.Controls.Add(this.txtSBDemo);
            this.groupBox3.Controls.Add(this.lblSLDemo);
            this.groupBox3.Controls.Add(this.lblIrDemo);
            this.groupBox3.Controls.Add(this.lblInssDemo);
            this.groupBox3.Controls.Add(this.lblSBDemo);
            this.groupBox3.Location = new System.Drawing.Point(523, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 326);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Demonstração";
            // 
            // txtSLDemo
            // 
            this.txtSLDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLDemo.Location = new System.Drawing.Point(19, 280);
            this.txtSLDemo.Name = "txtSLDemo";
            this.txtSLDemo.Size = new System.Drawing.Size(134, 29);
            this.txtSLDemo.TabIndex = 10;
            // 
            // txtIrDemo
            // 
            this.txtIrDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIrDemo.Location = new System.Drawing.Point(19, 205);
            this.txtIrDemo.Name = "txtIrDemo";
            this.txtIrDemo.Size = new System.Drawing.Size(134, 29);
            this.txtIrDemo.TabIndex = 9;
            // 
            // txtInssDemo
            // 
            this.txtInssDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInssDemo.Location = new System.Drawing.Point(19, 130);
            this.txtInssDemo.Name = "txtInssDemo";
            this.txtInssDemo.Size = new System.Drawing.Size(134, 29);
            this.txtInssDemo.TabIndex = 8;
            // 
            // txtSBDemo
            // 
            this.txtSBDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSBDemo.Location = new System.Drawing.Point(19, 55);
            this.txtSBDemo.Name = "txtSBDemo";
            this.txtSBDemo.Size = new System.Drawing.Size(134, 29);
            this.txtSBDemo.TabIndex = 5;
            // 
            // lblSLDemo
            // 
            this.lblSLDemo.AutoSize = true;
            this.lblSLDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLDemo.Location = new System.Drawing.Point(15, 253);
            this.lblSLDemo.Name = "lblSLDemo";
            this.lblSLDemo.Size = new System.Drawing.Size(134, 24);
            this.lblSLDemo.TabIndex = 7;
            this.lblSLDemo.Text = "Salário Líquido";
            // 
            // lblIrDemo
            // 
            this.lblIrDemo.AutoSize = true;
            this.lblIrDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIrDemo.Location = new System.Drawing.Point(15, 178);
            this.lblIrDemo.Name = "lblIrDemo";
            this.lblIrDemo.Size = new System.Drawing.Size(27, 24);
            this.lblIrDemo.TabIndex = 6;
            this.lblIrDemo.Text = "IR";
            // 
            // lblInssDemo
            // 
            this.lblInssDemo.AutoSize = true;
            this.lblInssDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInssDemo.Location = new System.Drawing.Point(15, 103);
            this.lblInssDemo.Name = "lblInssDemo";
            this.lblInssDemo.Size = new System.Drawing.Size(52, 24);
            this.lblInssDemo.TabIndex = 5;
            this.lblInssDemo.Text = "INSS";
            // 
            // lblSBDemo
            // 
            this.lblSBDemo.AutoSize = true;
            this.lblSBDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBDemo.Location = new System.Drawing.Point(15, 28);
            this.lblSBDemo.Name = "lblSBDemo";
            this.lblSBDemo.Size = new System.Drawing.Size(116, 24);
            this.lblSBDemo.TabIndex = 4;
            this.lblSBDemo.Text = "Salário Bruto";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 449);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(200, 100);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(572, 449);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(200, 100);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmFolhaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmFolhaPagamento";
            this.Text = "FolhaPagamento";
            this.Load += new System.EventHandler(this.frmFolhaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtClassC;
        private System.Windows.Forms.RadioButton rbtClassB;
        private System.Windows.Forms.RadioButton rbtClassA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSLDemo;
        private System.Windows.Forms.TextBox txtIrDemo;
        private System.Windows.Forms.TextBox txtInssDemo;
        private System.Windows.Forms.TextBox txtSBDemo;
        private System.Windows.Forms.Label lblSLDemo;
        private System.Windows.Forms.Label lblIrDemo;
        private System.Windows.Forms.Label lblInssDemo;
        private System.Windows.Forms.Label lblSBDemo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}