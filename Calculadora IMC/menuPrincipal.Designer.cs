
namespace Calculadora_IMC
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnImc = new System.Windows.Forms.Button();
            this.btnComb = new System.Windows.Forms.Button();
            this.btnFolhaP = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImc
            // 
            this.btnImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImc.Image = ((System.Drawing.Image)(resources.GetObject("btnImc.Image")));
            this.btnImc.Location = new System.Drawing.Point(8, 11);
            this.btnImc.Name = "btnImc";
            this.btnImc.Padding = new System.Windows.Forms.Padding(5);
            this.btnImc.Size = new System.Drawing.Size(230, 250);
            this.btnImc.TabIndex = 0;
            this.btnImc.Text = "IMC";
            this.btnImc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImc.UseVisualStyleBackColor = true;
            this.btnImc.Click += new System.EventHandler(this.btnImc_Click);
            // 
            // btnComb
            // 
            this.btnComb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComb.BackgroundImage")));
            this.btnComb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComb.Location = new System.Drawing.Point(277, 11);
            this.btnComb.Name = "btnComb";
            this.btnComb.Size = new System.Drawing.Size(230, 250);
            this.btnComb.TabIndex = 1;
            this.btnComb.Text = "Combustível";
            this.btnComb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComb.UseVisualStyleBackColor = true;
            this.btnComb.Click += new System.EventHandler(this.btnComb_Click);
            // 
            // btnFolhaP
            // 
            this.btnFolhaP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolhaP.BackgroundImage")));
            this.btnFolhaP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFolhaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolhaP.Location = new System.Drawing.Point(546, 11);
            this.btnFolhaP.Name = "btnFolhaP";
            this.btnFolhaP.Size = new System.Drawing.Size(230, 250);
            this.btnFolhaP.TabIndex = 2;
            this.btnFolhaP.Text = "Folha de Pagamento";
            this.btnFolhaP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFolhaP.UseVisualStyleBackColor = true;
            this.btnFolhaP.Click += new System.EventHandler(this.btnFolhaP_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 250);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(277, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 250);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(546, 267);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 250);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(545, 523);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(230, 38);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnFolhaP);
            this.Controls.Add(this.btnComb);
            this.Controls.Add(this.btnImc);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImc;
        private System.Windows.Forms.Button btnComb;
        private System.Windows.Forms.Button btnFolhaP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSair;
    }
}