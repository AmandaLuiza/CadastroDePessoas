namespace CadastroDePessoas
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(488, 429);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(502, 102);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(676, 156);
            this.txbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(310, 31);
            this.txbNome.TabIndex = 2;
            this.txbNome.Text = "Ana";
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(676, 273);
            this.txbTelefone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(310, 31);
            this.txbTelefone.TabIndex = 4;
            this.txbTelefone.Text = "123";
            this.txbTelefone.TextChanged += new System.EventHandler(this.txbTelefone_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTelefone;
    }
}

