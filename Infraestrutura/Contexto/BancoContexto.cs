using Microsoft.EntityFrameworkCore;
using System;
using Dominio.Modelo;
using Infraestrutura.Mapeamento;

namespace Infraestrutura
{
    public class BancoContexto : DbContext
    {
        public BancoContexto()
        {
        }

        public BancoContexto(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pedido> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoMapping());

        } 
    }
}
