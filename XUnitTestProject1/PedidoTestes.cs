using Dominio.Aplicacao;
using Dominio.DTO;
using Dominio.Modelo;
using Dominio.Repositorio;
using Moq;
using Newtonsoft.Json;
using Servico;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace TesteUnitario
{

    public class PedidoTestes
    {
        private readonly IPedidoService _service;
        private readonly Mock<IPedidoRepositorio> _mock = new Mock<IPedidoRepositorio>();
    

        public PedidoTestes()
        {
            _service = new PedidoServico(_mock.Object);
        }

        public List<PedidoDTO> ObterPedidosMock()
        {
            var json = File.ReadAllText(@"C:\Users\anabr\source\repos\UcdbPedido\XUnitTestProject1\Mock\PedidoJson.json", Encoding.GetEncoding("iso-8859-1"));
            var lista = JsonConvert.DeserializeObject<List<PedidoDTO>>(json);
            return lista;
        }

        [Fact]
        public void ObterPedidosVencidos()
        {
            //arrange
            var pedidos = ObterPedidosMock().Where(x=>x.DataVencimento < DateTime.Now).ToList();
            //action
            var pedidoService = _service.ObterPedidosVencidos();
            //assert
            Assert.Same(pedidos, pedidoService);
        }
    }
}
