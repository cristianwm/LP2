
namespace PIMC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblObesidade = new System.Windows.Forms.Label();
            this.txtObesidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(468, 69);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(468, 124);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 29);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(268, 365);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 43);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(94, 76);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(71, 20);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso (KG)";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(94, 131);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(76, 20);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura (M)";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(98, 189);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(35, 20);
            this.lblIMC.TabIndex = 5;
            this.lblIMC.Text = "IMC";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(98, 246);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(94, 20);
            this.lblClassificacao.TabIndex = 6;
            this.lblClassificacao.Text = "Classificação";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(251, 69);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(125, 27);
            this.txtPeso.TabIndex = 7;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(251, 124);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(125, 27);
            this.txtAltura.TabIndex = 8;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIMC.Location = new System.Drawing.Point(251, 182);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(125, 27);
            this.txtIMC.TabIndex = 9;
            this.txtIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Enabled = false;
            this.txtClassificacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtClassificacao.Location = new System.Drawing.Point(251, 239);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(125, 27);
            this.txtClassificacao.TabIndex = 10;
            this.txtClassificacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClassificacao.TextChanged += new System.EventHandler(this.txtClassificacao_TextChanged);
            // 
            // lblObesidade
            // 
            this.lblObesidade.AutoSize = true;
            this.lblObesidade.Location = new System.Drawing.Point(94, 303);
            this.lblObesidade.Name = "lblObesidade";
            this.lblObesidade.Size = new System.Drawing.Size(126, 20);
            this.lblObesidade.TabIndex = 11;
            this.lblObesidade.Text = "Obesidade (Grau)";
            this.lblObesidade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtObesidade
            // 
            this.txtObesidade.Enabled = false;
            this.txtObesidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtObesidade.Location = new System.Drawing.Point(251, 296);
            this.txtObesidade.Name = "txtObesidade";
            this.txtObesidade.Size = new System.Drawing.Size(125, 27);
            this.txtObesidade.TabIndex = 12;
            this.txtObesidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 436);
            this.Controls.Add(this.txtObesidade);
            this.Controls.Add(this.lblObesidade);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Name = "Form1";
            this.Text = "Cálculo de IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblObesidade;
        private System.Windows.Forms.TextBox txtObesidade;
    }
}

