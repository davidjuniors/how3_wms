
namespace how3_wms
{
    partial class form_Index
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
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnColeta = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnMovimenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(40, 36);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(196, 69);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnColeta
            // 
            this.btnColeta.Location = new System.Drawing.Point(278, 36);
            this.btnColeta.Name = "btnColeta";
            this.btnColeta.Size = new System.Drawing.Size(196, 69);
            this.btnColeta.TabIndex = 1;
            this.btnColeta.Text = "Coletar";
            this.btnColeta.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(278, 143);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(196, 69);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventário";
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnMovimenta
            // 
            this.btnMovimenta.Location = new System.Drawing.Point(40, 143);
            this.btnMovimenta.Name = "btnMovimenta";
            this.btnMovimenta.Size = new System.Drawing.Size(196, 69);
            this.btnMovimenta.TabIndex = 2;
            this.btnMovimenta.Text = "Movimentação";
            this.btnMovimenta.UseVisualStyleBackColor = true;
            // 
            // form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 257);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnMovimenta);
            this.Controls.Add(this.btnColeta);
            this.Controls.Add(this.btnEstoque);
            this.Name = "form_Index";
            this.Text = "Gerencia Estoque C# (WMS)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnColeta;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMovimenta;
    }
}

