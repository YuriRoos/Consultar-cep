namespace WFConsultasCep
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.btnBuscarCep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(15, 55);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(204, 20);
            this.txtendereco.TabIndex = 1;
            // 
            // btnBuscarCep
            // 
            this.btnBuscarCep.Location = new System.Drawing.Point(241, 53);
            this.btnBuscarCep.Name = "btnBuscarCep";
            this.btnBuscarCep.Size = new System.Drawing.Size(75, 22);
            this.btnBuscarCep.TabIndex = 2;
            this.btnBuscarCep.Text = "Buscar Cep";
            this.btnBuscarCep.UseVisualStyleBackColor = true;
            this.btnBuscarCep.Click += new System.EventHandler(this.btnBuscarCep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 113);
            this.Controls.Add(this.btnBuscarCep);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Button btnBuscarCep;
    }
}

