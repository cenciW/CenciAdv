using System.Text.Json;
using CenciAdv.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CenciAdv.Teste
{
    [TestClass]
    public class UnitTestRepository

    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Cidade> Cidade { get; set; }
            public DbSet<ClassificacaoTransacao> ClassificacaoTransacao { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
            public DbSet<Consulta> Consulta { get; set; }
            public DbSet<Transacao> Transacao { get; set; }
            public DbSet<Usuario> Usuario { get; set; }

            public MyDbContext()
            {

                //Database.EnsureCreated();

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "IFSPStore";
                var username = "root";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            }
        }
        
        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var context = new MyDbContext())
            {

                var usuario = new Usuario
                {
                    Nome = "Murilo",
                    Email = "murilo@mail.com",
                    //Login = "muvarg",
                    Senha = "123",
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now
                };
                context.Usuario.Add(usuario);

                context.SaveChanges();
                
                usuario = new Usuario
                {
                    Nome = "João",
                    Email = "joao@mail.com",
                    //Login = "muvarg",
                    Senha = "123",
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now
                };
                context.Usuario.Add(usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListarUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuario)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }
    }
}