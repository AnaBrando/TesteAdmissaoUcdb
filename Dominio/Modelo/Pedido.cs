using System;

namespace Dominio.Modelo
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}
