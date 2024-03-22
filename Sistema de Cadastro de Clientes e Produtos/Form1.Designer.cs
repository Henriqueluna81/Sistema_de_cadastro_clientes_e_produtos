namespace Sistema_de_Cadastro_de_Clientes_e_Produtos
{
    partial class Tela_inicial
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
            System.Windows.Forms.Label LB_tituloOPcoes;
            this.BT_CadastroCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            LB_tituloOPcoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_tituloOPcoes
            // 
            LB_tituloOPcoes.AutoSize = true;
            LB_tituloOPcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LB_tituloOPcoes.Location = new System.Drawing.Point(58, 92);
            LB_tituloOPcoes.Name = "LB_tituloOPcoes";
            LB_tituloOPcoes.Size = new System.Drawing.Size(371, 29);
            LB_tituloOPcoes.TabIndex = 0;
            LB_tituloOPcoes.Text = "Escolha uma das opções a baixo:";
            LB_tituloOPcoes.Click += new System.EventHandler(this.LB_tituloOPcoes_Click);
            // 
            // BT_CadastroCliente
            // 
            this.BT_CadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CadastroCliente.Location = new System.Drawing.Point(123, 161);
            this.BT_CadastroCliente.Name = "BT_CadastroCliente";
            this.BT_CadastroCliente.Size = new System.Drawing.Size(225, 37);
            this.BT_CadastroCliente.TabIndex = 1;
            this.BT_CadastroCliente.Text = "Cadastrar cliente";
            this.BT_CadastroCliente.UseVisualStyleBackColor = true;
            this.BT_CadastroCliente.Click += new System.EventHandler(this.BT_CadastroCliente_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar produto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT_CadastroCliente);
            this.Controls.Add(LB_tituloOPcoes);
            this.MaximizeBox = false;
            this.Name = "Tela_inicial";
            this.Text = "Cadastro no sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_CadastroCliente;
        private System.Windows.Forms.Button button1;
    }
}

