using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace how3_wms
{
    public partial class form_Index : Form
    {
        Thread coletar;
        Thread movimentar;
        Thread inventario;
        Thread estoque;
        Thread produtos;
        Thread pedidos;

        public form_Index()
        {
            InitializeComponent();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            //this.Close();
            estoque = new Thread(Estoque);
            estoque.SetApartmentState(ApartmentState.STA);
            estoque.Start();
        }

        private void btnColeta_Click(object sender, EventArgs e)
        {
            coletar = new Thread(Coletar);
            coletar.SetApartmentState(ApartmentState.STA);
            coletar.Start();
        }

        private void btnMovimenta_Click(object sender, EventArgs e)
        {
            movimentar = new Thread(Movimentar);
            movimentar.SetApartmentState(ApartmentState.STA);
            movimentar.Start();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            inventario = new Thread(Inventario);
            inventario.SetApartmentState(ApartmentState.STA);
            inventario.Start();
        }

        private void Estoque()
        {
            Application.Run(new EstoqueIndex());
        }

        private void Coletar()
        {
            Application.Run(new ColetaIndex());
        }

        private void Movimentar()
        {
            Application.Run(new MovimentacaoIndex());
        }

        private void Inventario()
        {
            Application.Run(new InventarioIndex());
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            produtos = new Thread(Produtos);
            produtos.SetApartmentState(ApartmentState.STA);
            produtos.Start();
        }

        private void Produtos()
        {
            Application.Run(new Produtos());
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            pedidos = new Thread(Pedidos);
            pedidos.SetApartmentState(ApartmentState.STA);
            pedidos.Start();

        }
        private void Pedidos()
        {
            Application.Run(new PedidosIndex());
        }
    }
}
