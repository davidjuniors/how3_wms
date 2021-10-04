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
    public partial class MovimentacaoIndex : Form
    {
        public MovimentacaoIndex()
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

        private void btnMover_Click(object sender, EventArgs e)
        {
            int enderecoAtual, enderecoNovo, produtoId;

            MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
            MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());
            MySqlConnection realizaConexaoDB1 = new MySqlConnection(conexaoDB.ToString());
            MySqlConnection realizaConexaoDB2 = new MySqlConnection(conexaoDB.ToString());

            try
            {
                realizaConexaoDB.Open();

                MySqlCommand comandoMySql1 = realizaConexaoDB.CreateCommand();
                MySqlCommand comandoMySql2 = realizaConexaoDB1.CreateCommand();
                MySqlCommand comandoMySql3 = realizaConexaoDB2.CreateCommand();

                //Pegar Endereço
                comandoMySql1.CommandText = "SELECT id FROM enderecos WHERE endereco = '" + txEndereco.Text + "'";
                MySqlDataReader reader = comandoMySql1.ExecuteReader();
                enderecoAtual = reader.GetInt32(0);
                
                //Pegar Novo Endereço
                comandoMySql2.CommandText = "SELECT id FROM enderecos WHERE endereco = '" + txNovoEndereco.Text + "'";
                MySqlDataReader reader2 = comandoMySql2.ExecuteReader();
                enderecoNovo = reader2.GetInt32(0);


                //Pegar Novo Endereço
                comandoMySql3.CommandText = "SELECT id FROM produtos WHERE ean_code = '" + txEanCode.Text + "'";
                MySqlDataReader reader3 = comandoMySql3.ExecuteReader();
                produtoId = reader3.GetInt32(0);

                //Verificar -> A implementar...
                MessageBox.Show(enderecoAtual.ToString());
                MessageBox.Show(enderecoNovo.ToString());
                MessageBox.Show(produtoId.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
