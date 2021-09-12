
namespace PTriangulo
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtTriangulo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(85, 79);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(56, 20);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Lado A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(85, 147);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(55, 20);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "Lado B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(85, 214);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(55, 20);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Lado C";
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(85, 284);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(71, 20);
            this.lblTriangulo.TabIndex = 3;
            this.lblTriangulo.Text = "Triângulo";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(212, 79);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(125, 27);
            this.txtA.TabIndex = 4;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(212, 140);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(125, 27);
            this.txtB.TabIndex = 5;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(212, 207);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(125, 27);
            this.txtC.TabIndex = 6;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTriangulo
            // 
            this.txtTriangulo.Enabled = false;
            this.txtTriangulo.Location = new System.Drawing.Point(212, 277);
            this.txtTriangulo.Name = "txtTriangulo";
            this.txtTriangulo.Size = new System.Drawing.Size(125, 27);
            this.txtTriangulo.TabIndex = 7;
            this.txtTriangulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(402, 79);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.ForeColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(402, 140);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 29);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(226, 336);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 40);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Executar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 429);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtTriangulo);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Tipo de triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtTriangulo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

