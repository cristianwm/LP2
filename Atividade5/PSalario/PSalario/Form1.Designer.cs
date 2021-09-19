
namespace PSalario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblDados = new System.Windows.Forms.Label();
            this.lblAINSS = new System.Windows.Forms.Label();
            this.lblAIRPF = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAINSS = new System.Windows.Forms.TextBox();
            this.txtAIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.mskbxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExe = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.gbxEstCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.txtNumFilhos = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.gbxEstCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(153, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(32, 73);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(95, 20);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salário bruto";
            this.lblSalBruto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(32, 122);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(124, 20);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de filhos";
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(32, 256);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(52, 20);
            this.lblDados.TabIndex = 3;
            this.lblDados.Text = "Dados";
            // 
            // lblAINSS
            // 
            this.lblAINSS.AutoSize = true;
            this.lblAINSS.Location = new System.Drawing.Point(32, 291);
            this.lblAINSS.Name = "lblAINSS";
            this.lblAINSS.Size = new System.Drawing.Size(101, 20);
            this.lblAINSS.TabIndex = 4;
            this.lblAINSS.Text = "Aliquota INSS";
            // 
            // lblAIRPF
            // 
            this.lblAIRPF.AutoSize = true;
            this.lblAIRPF.Location = new System.Drawing.Point(32, 341);
            this.lblAIRPF.Name = "lblAIRPF";
            this.lblAIRPF.Size = new System.Drawing.Size(98, 20);
            this.lblAIRPF.TabIndex = 5;
            this.lblAIRPF.Text = "Aliquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(32, 392);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(106, 20);
            this.lblSalFamilia.TabIndex = 6;
            this.lblSalFamilia.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(32, 444);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(109, 20);
            this.lblSalLiq.TabIndex = 7;
            this.lblSalLiq.Text = "Salário Líquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Desconto INSS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Desconto IRPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(191, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(151, 27);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAINSS
            // 
            this.txtAINSS.Enabled = false;
            this.txtAINSS.Location = new System.Drawing.Point(142, 284);
            this.txtAINSS.Name = "txtAINSS";
            this.txtAINSS.Size = new System.Drawing.Size(63, 27);
            this.txtAINSS.TabIndex = 13;
            this.txtAINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAIRPF
            // 
            this.txtAIRPF.Enabled = false;
            this.txtAIRPF.Location = new System.Drawing.Point(142, 334);
            this.txtAIRPF.Name = "txtAIRPF";
            this.txtAIRPF.Size = new System.Drawing.Size(63, 27);
            this.txtAIRPF.TabIndex = 14;
            this.txtAIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(142, 385);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.Size = new System.Drawing.Size(151, 27);
            this.txtSalFamilia.TabIndex = 15;
            this.txtSalFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalFamilia.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Enabled = false;
            this.txtSalLiq.Location = new System.Drawing.Point(142, 437);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(151, 27);
            this.txtSalLiq.TabIndex = 16;
            this.txtSalLiq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalLiq.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtINSS
            // 
            this.txtINSS.Enabled = false;
            this.txtINSS.Location = new System.Drawing.Point(332, 281);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(125, 27);
            this.txtINSS.TabIndex = 17;
            this.txtINSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Enabled = false;
            this.txtIRPF.Location = new System.Drawing.Point(332, 333);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(125, 27);
            this.txtIRPF.TabIndex = 18;
            this.txtIRPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskbxSalBruto
            // 
            this.mskbxSalBruto.Location = new System.Drawing.Point(191, 66);
            this.mskbxSalBruto.Name = "mskbxSalBruto";
            this.mskbxSalBruto.Size = new System.Drawing.Size(151, 27);
            this.mskbxSalBruto.TabIndex = 1;
            this.mskbxSalBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskbxSalBruto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(248, 205);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(384, 205);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 29);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExe
            // 
            this.btnExe.ForeColor = System.Drawing.Color.Black;
            this.btnExe.Location = new System.Drawing.Point(111, 205);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(94, 29);
            this.btnExe.TabIndex = 3;
            this.btnExe.Text = "Executar";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Location = new System.Drawing.Point(397, 8);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(150, 88);
            this.gbxSexo.TabIndex = 25;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(6, 56);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(97, 24);
            this.rbtnMasc.TabIndex = 28;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            this.rbtnMasc.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(6, 26);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(91, 24);
            this.rbtnFem.TabIndex = 27;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // gbxEstCivil
            // 
            this.gbxEstCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstCivil.Location = new System.Drawing.Point(397, 102);
            this.gbxEstCivil.Name = "gbxEstCivil";
            this.gbxEstCivil.Size = new System.Drawing.Size(150, 86);
            this.gbxEstCivil.TabIndex = 26;
            this.gbxEstCivil.TabStop = false;
            this.gbxEstCivil.Text = "Estado Civil";
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(12, 56);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(100, 24);
            this.rbtnSolteiro.TabIndex = 29;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro(a)";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(12, 26);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(97, 24);
            this.rbtnCasado.TabIndex = 28;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado(a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            this.rbtnCasado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtNumFilhos
            // 
            this.txtNumFilhos.Location = new System.Drawing.Point(191, 119);
            this.txtNumFilhos.Name = "txtNumFilhos";
            this.txtNumFilhos.Size = new System.Drawing.Size(151, 27);
            this.txtNumFilhos.TabIndex = 2;
            this.txtNumFilhos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 505);
            this.Controls.Add(this.txtNumFilhos);
            this.Controls.Add(this.gbxEstCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskbxSalBruto);
            this.Controls.Add(this.txtIRPF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAIRPF);
            this.Controls.Add(this.txtAINSS);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lblAIRPF);
            this.Controls.Add(this.lblAINSS);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Desconto de Salário";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstCivil.ResumeLayout(false);
            this.gbxEstCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Label lblAINSS;
        private System.Windows.Forms.Label lblAIRPF;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAINSS;
        private System.Windows.Forms.TextBox txtAIRPF;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxSalBruto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.GroupBox gbxEstCivil;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.TextBox txtNumFilhos;
    }
}

