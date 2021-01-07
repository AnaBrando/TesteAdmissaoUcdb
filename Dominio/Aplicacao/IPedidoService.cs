using Dominio.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Aplicacao
{
    public interface IPedidoService
    {
        List<PedidoDTO> ObterPedidosVencidos();

        List<PedidoDTO> ObterPedidosQuaseVencidos();

        List<PedidoDTO> ObterPedidosValidos();

        decimal ValorComDesconto(PedidoDTO dto);
    }
}
