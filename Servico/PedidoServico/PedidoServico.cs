using Dominio.Aplicacao;
using Dominio.DTO;
using Dominio.Repositorio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Servico
{
    public class PedidoServico : IPedidoService
    {
        private readonly IPedidoRepositorio _repo;

        //Testes Unitarios
        public List<PedidoDTO> ObterPedidosMock()
        {
            var json = File.ReadAllText(@"C:\Users\anabr\source\repos\UcdbPedido\XUnitTestProject1\Mock\PedidoJson.json", Encoding.GetEncoding("iso-8859-1"));
            var lista = JsonConvert.DeserializeObject<List<PedidoDTO>>(json);
            return lista;
        }
        public PedidoServico(IPedidoRepositorio repo)
        {
            _repo = repo;
        }
        public List<PedidoDTO> ObterPedidosQuaseVencidos()
        {
            throw new NotImplementedException();
        }

        public List<PedidoDTO> ObterPedidosValidos()
        {
            throw new NotImplementedException();
        }

        public List<PedidoDTO> ObterPedidosVencidos()
        {
            return ObterPedidosMock().Where(x => x.DataVencimento < DateTime.Now).ToList();

        }

        public decimal ValorComDesconto(PedidoDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
