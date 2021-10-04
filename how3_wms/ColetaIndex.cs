using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace how3_wms
{
    public partial class ColetaIndex : Form
    {
		int produtoId = 0;
		int quantidadeParaColetar = 0;
		int pedidoId = 0;

        public ColetaIndex()
        {
            InitializeComponent();
        }

		private MySqlConnectionStringBuilder conexaoBanco()
		{
			MySqlConnectionStringBuilder conexaoDB = new MySqlConnectionStringBuilder();

			conexaoDB.Server = "localhost";
			conexaoDB.Database = "how3_wms";
			conexaoDB.UserID = "root";
			conexaoDB.Password = "jtrading";
			conexaoDB.SslMode = 0;
			return conexaoDB;
		}

		private void atualziarJanela()
		{
			MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
			MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

			try
			{
				realizaConexaoDB.Open();

				MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
				comandoMySql.CommandText = "SELECT produtos.produto, enderecos.endereco, pedidos.quantidade, pedidos.done, pedidos.`order`, pedidos.produto, pedidos.id FROM pedidos INNER JOIN produtos ON pedidos.produto = produtos.id INNER JOIN produtos_estoque ON pedidos.produto = produtos_estoque.produto INNER JOIN enderecos ON produtos_estoque.endereco = enderecos.id LIMIT 1";
				MySqlDataReader reader = comandoMySql.ExecuteReader();

				while (reader.Read())
				{
					produtoId = reader.GetInt32(5);
					pedidoId = reader.GetInt32(6);
					lbProduto.Text = reader.GetString(0);
					lbEndereco.Text = reader.GetString(1);
					lbQtdColetar.Text = reader.GetString(2);
					quantidadeParaColetar = reader.GetInt32(2);
					lbPedido.Text = reader.GetString(4);
				}


				realizaConexaoDB.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection !");
				Console.WriteLine(ex.Message);
			}
		}

		private void ColetaIndex_Load(object sender, EventArgs e)
        {
			atualziarJanela();
		}

        private void btnColetar_Click(object sender, EventArgs e)
        {
			int itemColetado = 0;

			MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
			MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

			try
			{
				realizaConexaoDB.Open();

				MySqlCommand comandoMySql1 = realizaConexaoDB.CreateCommand();
				comandoMySql1.CommandText = "SELECT id, ean_code FROM produtos WHERE ean_code = " + txtEanCode.Text; 
				MySqlDataReader reader = comandoMySql1.ExecuteReader();

				while (reader.Read())
				{
					itemColetado = reader.GetInt32(0);
				}
				realizaConexaoDB.Close();

				if (itemColetado != produtoId)
                {
					MessageBox.Show("Produto errado. \nColete o produto correto.");
					txtEanCode.Text = "";
					txtQtdColetado.Text = "";
					return;
                } else if (Int32.Parse(txtQtdColetado.Text) != Int32.Parse(quantidadeParaColetar.ToString()))
                {
					MessageBox.Show("Quantidade coletada incorreta.\n Colete novamente.");
					txtEanCode.Text = "";
					txtQtdColetado.Text = "";
					return;
				} else
                {
					realizaConexaoDB.Open();

					MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
					comandoMySql.CommandText = "UPDATE pedidos SET done = true WHERE id = " + pedidoId;

					comandoMySql.ExecuteNonQuery();

					realizaConexaoDB.Close();
					MessageBox.Show("Produto coletado com sucesso");
					txtEanCode.Text = "";
					txtQtdColetado.Text = "";
					atualziarJanela();
					this.Close();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}
	}
}
