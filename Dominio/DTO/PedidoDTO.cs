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
    }
}
