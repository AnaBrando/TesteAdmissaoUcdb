using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.DTO
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        public override bool Equals(object obj)
        {
            return obj is PedidoDTO dTO &&
                   Id == dTO.Id &&
                   Nome == dTO.Nome &&
                   Valor == dTO.Valor &&
                   DataVencimento == dTO.DataVencimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Valor, DataVencimento);
        }
    }
}
