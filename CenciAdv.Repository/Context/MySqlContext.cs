using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CenciAdv.Domain.Entities;
using System.Text.RegularExpressions;
using CenciAdv.Repository.Mapping;

namespace CenciAdv.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Cidade>? Cidade { get; set; }
        public DbSet<ClassificacaoTransacao>? ClassificacaoTransacao { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Consulta>? Consulta { get; set; }
        public DbSet<Transacao>? Transacao { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
            modelBuilder.Entity<ClassificacaoTransacao>(new ClassificacaoTransacaoMap().Configure);
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
            modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
            modelBuilder.Entity<Transacao>(new TransacaoMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
        }

    }
}
