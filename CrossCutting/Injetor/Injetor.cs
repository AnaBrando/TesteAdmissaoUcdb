using Dominio.Repositorio;
using Infraestrutura.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CrossCutting
{
    public class Injetor
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
        }
    }
}
