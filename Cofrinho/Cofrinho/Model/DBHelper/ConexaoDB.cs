using System.Data.SQLite;
using Dapper;

namespace Cofrinho.Model.DBHelper
{
    class ConexaoDB
    {
        private readonly string conexaoString = "Data Source=meubanco.db;Version=3;";
        private SQLiteConnection conexao;

        // Construtor para abrir a conexão ao criar um objeto da classe
        public ConexaoDB()
        {
            conexao = new SQLiteConnection(conexaoString);
            conexao.Open();
        }

        // Método para obter a conexão
        public SQLiteConnection GetConexao()
        {
            return conexao;
        }

        // Método para fechar a conexão (opcional)
        public void FecharConexao()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
