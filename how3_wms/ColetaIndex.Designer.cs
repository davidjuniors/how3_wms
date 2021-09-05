
namespace how3_wms
{
    partial class ColetaIndex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProduto = new System.Windows.Forms.Label();
            this.txtEanCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.btnColetar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdColetado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbQtdColetar = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 30);
            this.menuStrip1.TabIndex = 5;
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
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
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
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Location = new System.Drawing.Point(174, 69);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(0, 17);
            this.lbProduto.TabIndex = 7;
            // 
            // txtEanCode
            // 
            this.txtEanCode.Location = new System.Drawing.Point(37, 152);
            this.txtEanCode.Name = "txtEanCode";
            this.txtEanCode.Size = new System.Drawing.Size(270, 22);
            this.txtEanCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Endereço:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(174, 122);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(0, 17);
            this.lbEndereco.TabIndex = 10;
            // 
            // btnColetar
            // 
            this.btnColetar.Location = new System.Drawing.Point(203, 244);
            this.btnColetar.Name = "btnColetar";
            this.btnColetar.Size = new System.Drawing.Size(103, 40);
            this.btnColetar.TabIndex = 11;
            this.btnColetar.Text = "Coletar";
            this.btnColetar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantidade:";
            // 
            // txtQtdColetado
            // 
            this.txtQtdColetado.Location = new System.Drawing.Point(206, 187);
            this.txtQtdColetado.Name = "txtQtdColetado";
            this.txtQtdColetado.Size = new System.Drawing.Size(100, 22);
            this.txtQtdColetado.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Coletar:";
            // 
            // lbQtdColetar
            // 
            this.lbQtdColetar.AutoSize = true;
            this.lbQtdColetar.Location = new System.Drawing.Point(34, 244);
            this.lbQtdColetar.Name = "lbQtdColetar";
            this.lbQtdColetar.Size = new System.Drawing.Size(0, 17);
            this.lbQtdColetar.TabIndex = 15;
            // 
            // ColetaIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 296);
            this.Controls.Add(this.lbQtdColetar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQtdColetado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnColetar);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEanCode);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ColetaIndex";
            this.Text = "Coletar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProduto;
        private System.Windows.Forms.TextBox txtEanCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Button btnColetar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdColetado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbQtdColetar;
    }
}