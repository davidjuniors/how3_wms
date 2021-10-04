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
using System.Threading;

namespace how3_wms
{
    public partial class Produtos : Form
    {

        public Produtos()
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
				comandoMySql.CommandText = "SELECT * FROM produtos";
				MySqlDataReader reader = comandoMySql.ExecuteReader();


				dgProdutos.Rows.Clear();

				while (reader.Read())
				{
					DataGridViewRow row = (DataGridViewRow)dgProdutos.Rows[0].Clone();
					row.Cells[0].Value = reader.GetInt32(0);
					row.Cells[1].Value = reader.GetString(1);
					row.Cells[2].Value = reader.GetString(2);
					dgProdutos.Rows.Add(row);
				}

				realizaConexaoDB.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Can not open connection !");
				Console.WriteLine(ex.Message);
			}
		}

		private void Produtos_Load(object sender, EventArgs e)
        {
			atualziarGrid();
		}

        private void btnProdutos_Click(object sender, EventArgs e)
        {
			MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
			MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

			if (txId.TextLength != 0)
            {
				try
				{
					realizaConexaoDB.Open();

					MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
					comandoMySql.CommandText = "UPDATE produtos SET produto = '" + txProduto.Text + "', ean_code = '" + txEanCode.Text + "' WHERE id = " + txId.Text;
					comandoMySql.ExecuteNonQuery();

					realizaConexaoDB.Close();
					MessageBox.Show("Produto atualizado com sucesso");
					atualziarGrid();

				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			else if (txEanCode.TextLength != 0 && txProduto.TextLength != 0 && txId.Text == "")
            {
				try
				{
					realizaConexaoDB.Open();

					MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
					comandoMySql.CommandText = "INSERT INTO produtos SET produto = '" + txProduto.Text + "', ean_code = '" + txEanCode.Text + "'";
					comandoMySql.ExecuteNonQuery();

					realizaConexaoDB.Close();
					MessageBox.Show("Produto inserido com sucesso");
					atualziarGrid();

					txProduto.Text = "";
					txId.Text = "";
					txEanCode.Text = "";

				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}

        private void dgProdutos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dgProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				dgProdutos.CurrentRow.Selected = true;
				txProduto.Text = dgProdutos.Rows[e.RowIndex].Cells["ColumnProduto"].FormattedValue.ToString();
				txEanCode.Text = dgProdutos.Rows[e.RowIndex].Cells["ColumnEan"].FormattedValue.ToString();
				txId.Text = dgProdutos.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
			}
		}

        private void dgProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dgProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				dgProdutos.CurrentRow.Selected = true;
				txProduto.Text = dgProdutos.Rows[e.RowIndex].Cells["ColumnProduto"].FormattedValue.ToString();
				txEanCode.Text = dgProdutos.Rows[e.RowIndex].Cells["ColumnEan"].FormattedValue.ToString();
				txId.Text = dgProdutos.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
			}
		}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
			txProduto.Text = "";
			txId.Text = "";
			txEanCode.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
			MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
			MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

			try
			{
				realizaConexaoDB.Open();

				MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
				comandoMySql.CommandText = "DELETE FROM produtos WHERE id = " + txId.Text;
				comandoMySql.ExecuteNonQuery();

				realizaConexaoDB.Close();
				atualziarGrid();

				txProduto.Text = "";
				txId.Text = "";
				txEanCode.Text = "";

				MessageBox.Show("Produto apagado com sucesso");

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
    }
}
