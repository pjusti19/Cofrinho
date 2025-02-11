using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SQLite;
using Cofrinho.Model.DTO;
using Cofrinho.Model.DBHelper;

namespace Cofrinho.Model.DAO
{
    public class RegistroDAO
    {
        private readonly ConexaoDB conexaoDB;

        public RegistroDAO()
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
                    CREATE TABLE IF NOT EXISTS Registro (
                        IdentificadorRegistro TEXT PRIMARY KEY,
                        FkExtrato INTEGER,
                        Descricao TEXT NOT NULL,
                        Valor DECIMAL(10,2) NOT NULL,
                        DataDoGasto DATETIME NOT NULL
                    );
                ");
            }
        }

        public void Inserir(Registro registro)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = @"INSERT INTO Registro (IdentificadorRegistro, FkExtrato, Descricao, Valor, DataDoGasto) 
                               VALUES (@IdentificadorRegistro, @FkExtrato, @Descricao, @Valor, @DataDoGasto)";
                conexao.Execute(sql, registro);
            }
        }

        public List<Registro> ObterTodos()
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Registro";
                return conexao.Query<Registro>(sql).ToList();
            }
        }

        public Registro ObterPorId(string id)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM Registro WHERE IdentificadorRegistro = @Id";
                var registro = conexao.QueryFirstOrDefault<Registro>(sql, new { Id = id });

                if (registro == null)
                {
                    Console.WriteLine("Nenhum registro encontrado.");
                }

                return registro;
            }
        }

        public void Atualizar(Registro registro)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = @"UPDATE Registro 
                               SET FkExtrato = @FkExtrato, 
                                   Descricao = @Descricao, 
                                   Valor = @Valor, 
                                   DataDoGasto = @DataDoGasto
                               WHERE IdentificadorRegistro = @IdentificadorRegistro";
                conexao.Execute(sql, registro);
            }
        }

        public void Deletar(string id)
        {
            using (var conexao = conexaoDB.GetConexao())
            {
                string sql = "DELETE FROM Registro WHERE IdentificadorRegistro = @Id";
                conexao.Execute(sql, new { Id = id });
            }
        }
    }
}
