using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho.Model.DTO
{
    public class Extrato
    {
        public int IdExtrato { get; set; }
        public string NomeRegistro { get; set; }
        public string NomeProprietario { get; set; }
        public string Descricao { get; set; }

        public Extrato(int id, string nome, string proprietario, string descricao)
        {
            IdExtrato = id;
            NomeRegistro = nome;
            NomeProprietario = proprietario;
            Descricao = descricao;

        }
    }
}
