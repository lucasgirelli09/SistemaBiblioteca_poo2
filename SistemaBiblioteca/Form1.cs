using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Necessário para realizar a conexão com o banco de dados MySQL.

namespace Products_CRUD
{
    public partial class Form1 : Form
    {
        // Singleton para conexão com o banco de dados.
        private static MySqlConnection _connection;
        private static readonly string connectionString = "server=localhost;" +
                                                          "user=root;password=123456;" +
                                                          "database=biblioteca;sslmode=none;";

        public Form1()
        {
            InitializeComponent();
            LoadBooks();
        }

        private static MySqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection(connectionString);
                }
                return _connection;
            }
        }

        // Método para carregar os livros na grid.
        private void LoadBooks()
        {
            string query = @"
                SELECT Livros.idLivro, Livros.Titulo, Livros.AnoPublicacao, Livros.Genero, 
                    GROUP_CONCAT(Autor.Nome SEPARATOR ', ') AS Autores
                FROM Livros
                LEFT JOIN Livros_has_Autor ON Livros.idLivro = Livros_has_Autor.Livros_idLivro
                LEFT JOIN Autor ON Livros_has_Autor.Autor_idAutor = Autor.idAutor
                GROUP BY Livros.idLivro";

            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, Connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;

                // Configuração das colunas
                dataGrid.Columns["Titulo"].HeaderText = "Título";
                dataGrid.Columns["AnoPublicacao"].HeaderText = "Ano de Publicação";
                dataGrid.Columns["Genero"].HeaderText = "Gênero";
                dataGrid.Columns["Autores"].HeaderText = "Autores";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtYear.Clear();
            txtGenre.Clear();
            txtAuthor.Clear();
            MessageBox.Show("Campos limpos com sucesso!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGrid.SelectedRows[0].Index;
                int livroId = Convert.ToInt32(dataGrid.Rows[selectedRowIndex].Cells["idLivro"].Value);

                var confirmResult = MessageBox.Show(
                    "Tem certeza de que deseja excluir este livro?",
                    "Confirmação",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        Connection.Open();
                        string query = "DELETE FROM Livros WHERE idLivro = @idLivro";
                        MySqlCommand cmd = new MySqlCommand(query, Connection);
                        cmd.Parameters.AddWithValue("@idLivro", livroId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Livro excluído com sucesso!");
                        LoadBooks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                    finally
                    {
                        Connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um livro para excluir.");
            }
        }
    }
}
