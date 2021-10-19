
namespace Ptestemetodos
{
    partial class FrmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnQuantAlfabetico = new System.Windows.Forms.Button();
            this.btnLocalizacao = new System.Windows.Forms.Button();
            this.btnQuanCaracter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(194, 119);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(365, 120);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnQuantAlfabetico
            // 
            this.btnQuantAlfabetico.Location = new System.Drawing.Point(483, 281);
            this.btnQuantAlfabetico.Name = "btnQuantAlfabetico";
            this.btnQuantAlfabetico.Size = new System.Drawing.Size(127, 77);
            this.btnQuantAlfabetico.TabIndex = 5;
            this.btnQuantAlfabetico.Text = "Quantidade de caracter alfabético";
            this.btnQuantAlfabetico.UseVisualStyleBackColor = true;
            this.btnQuantAlfabetico.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // btnLocalizacao
            // 
            this.btnLocalizacao.Location = new System.Drawing.Point(301, 281);
            this.btnLocalizacao.Name = "btnLocalizacao";
            this.btnLocalizacao.Size = new System.Drawing.Size(143, 77);
            this.btnLocalizacao.TabIndex = 4;
            this.btnLocalizacao.Text = "Localização do 1° caracter branco";
            this.btnLocalizacao.UseVisualStyleBackColor = true;
            this.btnLocalizacao.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnQuanCaracter
            // 
            this.btnQuanCaracter.Location = new System.Drawing.Point(121, 281);
            this.btnQuanCaracter.Name = "btnQuanCaracter";
            this.btnQuanCaracter.Size = new System.Drawing.Size(143, 77);
            this.btnQuanCaracter.TabIndex = 3;
            this.btnQuanCaracter.Text = "Quantidade de caracteres númericos";
            this.btnQuanCaracter.UseVisualStyleBackColor = true;
            this.btnQuanCaracter.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuantAlfabetico);
            this.Controls.Add(this.btnLocalizacao);
            this.Controls.Add(this.btnQuanCaracter);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnQuantAlfabetico;
        private System.Windows.Forms.Button btnLocalizacao;
        private System.Windows.Forms.Button btnQuanCaracter;
    }
}