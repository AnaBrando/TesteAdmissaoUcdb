using System;

namespace Dominio.Modelo
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Pedido pedido &&
                   Id == pedido.Id &&
                   Nome == pedido.Nome &&
                   Valor == pedido.Valor &&
                   DataVencimento == pedido.DataVencimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Valor, DataVencimento);
        }
    }
}
