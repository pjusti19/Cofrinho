using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofrinho.Model.DTO
{
    public class Registro
    {
        public string IdentificadorRegistro { get; set; }
        public int FkExtrato { get; set; } // FK para o Extrato correspondente
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataDoGasto { get; set; }

        public Registro(string id, int fk_extrato, string descricao, decimal valor, DateTime data)
        {
            IdentificadorRegistro = id;
            FkExtrato = fk_extrato;
            Descricao = descricao;
            Valor = valor;
            DataDoGasto = data;
        }
    }
}
