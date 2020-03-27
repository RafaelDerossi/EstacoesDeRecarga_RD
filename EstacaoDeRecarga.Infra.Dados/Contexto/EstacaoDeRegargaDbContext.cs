using EstacaoDeRecarga.Dominio.Modelos;
using EstacaoDeRecarga.Dominio.ObjetosDeValor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDeRecarga.Infra.Dados.Contexto
{
   public class EstacaoDeRegargaDbContext : DbContext
    {
        public DbSet<EstacaoRecarga> EstacaoRecarga { get; set; }
        public EstacaoDeRegargaDbContext()
        {

        }

        public EstacaoDeRegargaDbContext(DbContextOptions<EstacaoDeRegargaDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(GetConnectionString());

            base.OnConfiguring(optionsBuilder);
        }



        private string GetConnectionString()
        {
            //Alterar para configurações desejadas:
            return "Server=(localdb)\\MSSQLLocalDB;Database=BdEstacoesDeRegarga;Trusted_Connection=True;MultipleActiveResultSets=True;";
        }
    }
}
