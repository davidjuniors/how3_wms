
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBottom = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(38, 46);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(196, 69);
            this.btnEstoque.TabIndex = 0;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnColeta
            // 
            this.btnColeta.Location = new System.Drawing.Point(276, 46);
            this.btnColeta.Name = "btnColeta";
            this.btnColeta.Size = new System.Drawing.Size(196, 69);
            this.btnColeta.TabIndex = 1;
            this.btnColeta.Text = "Coletar";
            this.btnColeta.UseVisualStyleBackColor = true;
            this.btnColeta.Click += new System.EventHandler(this.btnColeta_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Location = new System.Drawing.Point(276, 153);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(196, 69);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventário";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnMovimenta
            // 
            this.btnMovimenta.Location = new System.Drawing.Point(38, 153);
            this.btnMovimenta.Name = "btnMovimenta";
            this.btnMovimenta.Size = new System.Drawing.Size(196, 69);
            this.btnMovimenta.TabIndex = 2;
            this.btnMovimenta.Text = "Movimentação";
            this.btnMovimenta.UseVisualStyleBackColor = true;
            this.btnMovimenta.Click += new System.EventHandler(this.btnMovimenta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "wmsMenu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.coletaToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.inventárioToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // coletaToolStripMenuItem
            // 
            this.coletaToolStripMenuItem.Name = "coletaToolStripMenuItem";
            this.coletaToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.coletaToolStripMenuItem.Text = "Coleta";
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            // 
            // inventárioToolStripMenuItem
            // 
            this.inventárioToolStripMenuItem.Name = "inventárioToolStripMenuItem";
            this.inventárioToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.inventárioToolStripMenuItem.Text = "Inventário";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // lbBottom
            // 
            this.lbBottom.AutoSize = true;
            this.lbBottom.Location = new System.Drawing.Point(139, 250);
            this.lbBottom.Name = "lbBottom";
            this.lbBottom.Size = new System.Drawing.Size(233, 17);
            this.lbBottom.TabIndex = 5;
            this.lbBottom.Text = "Gerênciamento de Estoques - 2021";
            // 
            // form_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 292);
            this.Controls.Add(this.lbBottom);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnMovimenta);
            this.Controls.Add(this.btnColeta);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_Index";
            this.Text = "Gerencia Estoque C# (WMS)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnColeta;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnMovimenta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lbBottom;
    }
}

