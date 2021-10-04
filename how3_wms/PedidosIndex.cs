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
    public partial class PedidosIndex : Form
    {
        public PedidosIndex()
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

		private void atualziarGrid()
		{
			MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
			MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

			try
			{
				realizaConexaoDB.Open();

				MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
				comandoMySql.CommandText = "SELECT pedidos.`order`, usuarios.nome, produtos.produto, pedidos.quantidade, pedidos.data_criado FROM pedidos INNER JOIN produtos ON pedidos.produto = produtos.id INNER JOIN usuarios ON pedidos.comprador = usuarios.id WHERE done = false";
				MySqlDataReader reader = comandoMySql.ExecuteReader();

				dgPedidos.Rows.Clear();

				while (reader.Read())
				{
					DataGridViewRow row = (DataGridViewRow)dgPedidos.Rows[0].Clone();
					row.Cells[0].Value = reader.GetInt32(0);
					row.Cells[1].Value = reader.GetString(1);
					row.Cells[2].Value = reader.GetString(2);
					row.Cells[3].Value = reader.GetInt32(3);
					row.Cells[4].Value = reader.GetDateTime(4);
					dgPedidos.Rows.Add(row);
				}

				realizaConexaoDB.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection !");
				Console.WriteLine(ex.Message);
			}
		}

        private void PedidosIndex_Load(object sender, EventArgs e)
        {
			atualziarGrid();
        }
    }
}
