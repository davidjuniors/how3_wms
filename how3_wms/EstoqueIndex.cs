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
    public partial class EstoqueIndex : Form
    {
        public EstoqueIndex()
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
				comandoMySql.CommandText = "SELECT produtos_estoque.id, produtos.produto, produtos_estoque.quantidade, enderecos.endereco FROM produtos_estoque INNER JOIN produtos ON produtos_estoque.produto = produtos.id INNER JOIN enderecos ON produtos_estoque.endereco = enderecos.id WHERE quantidade > 0";
				MySqlDataReader reader = comandoMySql.ExecuteReader();


				dgEstoque.Rows.Clear();

				while (reader.Read())
				{
					DataGridViewRow row = (DataGridViewRow)dgEstoque.Rows[0].Clone();
					row.Cells[0].Value = reader.GetInt32(0);
					row.Cells[1].Value = reader.GetString(1);
					row.Cells[2].Value = reader.GetInt32(2);
					row.Cells[3].Value = reader.GetString(3);
					dgEstoque.Rows.Add(row);
				}

				realizaConexaoDB.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection !");
				Console.WriteLine(ex.Message);
			}
		}

		private void EstoqueIndex_Load(object sender, EventArgs e)
        {
			atualziarGrid();
		}
    }
}
