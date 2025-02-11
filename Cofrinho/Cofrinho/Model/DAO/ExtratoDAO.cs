using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SQLite;
using Cofrinho.Model.DTO;
using Cofrinho.Model.DBHelper;

namespace Cofrinho.Model.DAO
{
    public class ExtratoDAO
    {
        private readonly ConexaoDB conexaoDB;

        public ExtratoDAO()
        {
            conexaoDB = new ConexaoDB();
            CriarTabela();
        }

        // Criar a tabela se não existir
        private void CriarTabela()
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                conexao.Execute(@"
                    CREATE TABLE IF NOT EXISTS Extrato (
                        IdExtrato INTEGER PRIMARY KEY,
                        NomeRegistro TEXT NOT NULL,
                        NomeProprietario TEXT NOT NULL,
                        Descricao TEXT NOT NULL
                    );
                ");
            }
        }

        public void Inserir(Extrato extrato)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO Extrato (IdExtrato, NomeRegistro, NomeProprietario, Descricao) 
                               VALUES (@IdExtrato, @NomeRegistro, @NomeProprietario, @Descricao)";
                conexao.Execute(sql, extrato);
            }
        }

        public List<Extrato> ObterTodos()
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Extrato";
                return conexao.Query<Extrato>(sql).ToList();
            }
        }

        public Extrato ObterPorId(int id)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Extrato WHERE IdExtrato = @Id";
                var extrato = conexao.QueryFirstOrDefault<Extrato>(sql, new { Id = id });

                if (extrato == null)
                {
                    Console.WriteLine("Nenhum extrato encontrado.");
                }

                return extrato;
            }
        }

        public void Atualizar(Extrato extrato)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = @"UPDATE Extrato 
                               SET NomeRegistro = @NomeRegistro, 
                                   NomeProprietario = @NomeProprietario, 
                                   Descricao = @Descricao
                               WHERE IdExtrato = @IdExtrato";
                conexao.Execute(sql, extrato);
            }
        }

        public void Deletar(int id)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = "DELETE FROM Extrato WHERE IdExtrato = @Id";
                conexao.Execute(sql, new { Id = id });
            }
        }
    }
}
