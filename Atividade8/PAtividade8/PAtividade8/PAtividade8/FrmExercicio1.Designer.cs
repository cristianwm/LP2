
namespace PAtividade8
{
    partial class FrmExercicio1
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
            this.btnEspaco = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnPar = new System.Windows.Forms.Button();
            this.rchtLetras = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnEspaco
            // 
            this.btnEspaco.Location = new System.Drawing.Point(131, 295);
            this.btnEspaco.Name = "btnEspaco";
            this.btnEspaco.Size = new System.Drawing.Size(140, 82);
            this.btnEspaco.TabIndex = 0;
            this.btnEspaco.Text = "Número de espaços em branco";
            this.btnEspaco.UseVisualStyleBackColor = true;
            this.btnEspaco.Click += new System.EventHandler(this.btnEspaco_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(299, 295);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(125, 82);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "Número de \"R\"";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnPar
            // 
            this.btnPar.Location = new System.Drawing.Point(458, 295);
            this.btnPar.Name = "btnPar";
            this.btnPar.Size = new System.Drawing.Size(136, 82);
            this.btnPar.TabIndex = 2;
            this.btnPar.Text = "Número de par de letras";
            this.btnPar.UseVisualStyleBackColor = true;
            this.btnPar.Click += new System.EventHandler(this.btnPar_Click);
            // 
            // rchtLetras
            // 
            this.rchtLetras.Location = new System.Drawing.Point(299, 66);
            this.rchtLetras.Name = "rchtLetras";
            this.rchtLetras.Size = new System.Drawing.Size(125, 120);
            this.rchtLetras.TabIndex = 3;
            this.rchtLetras.Text = "";
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchtLetras);
            this.Controls.Add(this.btnPar);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnEspaco);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEspaco;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnPar;
        private System.Windows.Forms.RichTextBox rchtLetras;
    }
}