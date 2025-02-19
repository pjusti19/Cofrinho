using Cofrinho.Model.DBHelper;
using Cofrinho.Model.DTO;
using Dapper;
using System.Data.SQLite;

public class ExtratoDAO : IDisposable
{
    private readonly SQLiteConnection _conexao;

    public ExtratoDAO()
    {
        _conexao = new ConexaoDB().GetConexao();
        CriarTabela();
    }

    // Criar a tabela se não existir
    private void CriarTabela()
    {
        _conexao.Execute(@"
            CREATE TABLE IF NOT EXISTS Extrato (
                IdExtrato INTEGER PRIMARY KEY AUTOINCREMENT,
                NomeRegistro TEXT NOT NULL,
                NomeProprietario TEXT NOT NULL,
                Descricao TEXT NOT NULL
            );
        ");
    }

    public void Inserir(Extrato extrato)
    {
        string sql = @"INSERT INTO Extrato (NomeRegistro, NomeProprietario, Descricao) 
                       VALUES (@NomeRegistro, @NomeProprietario, @Descricao)";
        _conexao.Execute(sql, extrato);
    }

    public List<Extrato> ObterTodos()
    {
        string sql = "SELECT * FROM Extrato";
        return _conexao.Query<Extrato>(sql).ToList();
    }

    public Extrato ObterPorId(int id)
    {
        string sql = "SELECT * FROM Extrato WHERE IdExtrato = @Id";
        return _conexao.QueryFirstOrDefault<Extrato>(sql, new { Id = id });
    }

    public void Atualizar(Extrato extrato)
    {
        string sql = @"UPDATE Extrato 
                       SET NomeRegistro = @NomeRegistro, 
                           NomeProprietario = @NomeProprietario, 
                           Descricao = @Descricao
                       WHERE IdExtrato = @IdExtrato";
        _conexao.Execute(sql, extrato);
    }

    public void Deletar(int id)
    {
        string sql = "DELETE FROM Extrato WHERE IdExtrato = @Id";
        _conexao.Execute(sql, new { Id = id });
    }

    // Método para fechar a conexão quando o objeto for descartado
    public void Dispose()
    {
        _conexao?.Close();
        _conexao?.Dispose();
    }
}
