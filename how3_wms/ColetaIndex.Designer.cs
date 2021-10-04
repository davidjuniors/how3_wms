
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
            this.lbPedido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto:";
            // 
            // lbProduto
            // 
            this.lbProduto.AutoSize = true;
            this.lbProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduto.Location = new System.Drawing.Point(174, 32);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(0, 18);
            this.lbProduto.TabIndex = 7;
            this.lbProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEanCode
            // 
            this.txtEanCode.Location = new System.Drawing.Point(37, 115);
            this.txtEanCode.Name = "txtEanCode";
            this.txtEanCode.Size = new System.Drawing.Size(270, 22);
            this.txtEanCode.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Endereço:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(174, 85);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(0, 17);
            this.lbEndereco.TabIndex = 10;
            // 
            // btnColetar
            // 
            this.btnColetar.Location = new System.Drawing.Point(203, 207);
            this.btnColetar.Name = "btnColetar";
            this.btnColetar.Size = new System.Drawing.Size(103, 40);
            this.btnColetar.TabIndex = 11;
            this.btnColetar.Text = "Coletar";
            this.btnColetar.UseVisualStyleBackColor = true;
            this.btnColetar.Click += new System.EventHandler(this.btnColetar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quantidade:";
            // 
            // txtQtdColetado
            // 
            this.txtQtdColetado.Location = new System.Drawing.Point(206, 150);
            this.txtQtdColetado.Name = "txtQtdColetado";
            this.txtQtdColetado.Size = new System.Drawing.Size(100, 22);
            this.txtQtdColetado.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Coletar:";
            // 
            // lbQtdColetar
            // 
            this.lbQtdColetar.AutoSize = true;
            this.lbQtdColetar.Location = new System.Drawing.Point(97, 185);
            this.lbQtdColetar.Name = "lbQtdColetar";
            this.lbQtdColetar.Size = new System.Drawing.Size(0, 17);
            this.lbQtdColetar.TabIndex = 15;
            // 
            // lbPedido
            // 
            this.lbPedido.AutoSize = true;
            this.lbPedido.Location = new System.Drawing.Point(113, 219);
            this.lbPedido.Name = "lbPedido";
            this.lbPedido.Size = new System.Drawing.Size(0, 17);
            this.lbPedido.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pedido Nº: ";
            // 
            // ColetaIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 266);
            this.Controls.Add(this.lbPedido);
            this.Controls.Add(this.label6);
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
            this.Name = "ColetaIndex";
            this.Text = "Coletar";
            this.Load += new System.EventHandler(this.ColetaIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lbPedido;
        private System.Windows.Forms.Label label6;
    }
}