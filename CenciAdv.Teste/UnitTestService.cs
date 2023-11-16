using System.Text.Json;
using AutoMapper;
using CenciAdv.Domain.Base;
using CenciAdv.Domain.Entities;
using CenciAdv.Repository.Context;
using CenciAdv.Repository.Mapping;
using CenciAdv.Repository.Repository;
using CenciAdv.Service.Services;
using CenciAdv.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using static CenciAdv.Teste.UnitTestRepository;

namespace CenciAdv.Teste
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;
        public ServiceProvider ConfiguraServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "cenciAdvDb";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";

                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();

            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();

            services.AddScoped<IBaseRepository<ClassificacaoTransacao>, BaseRepository<ClassificacaoTransacao>>();
            services.AddScoped<IBaseService<ClassificacaoTransacao>, BaseService<ClassificacaoTransacao>>();

            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();

            services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();
            services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();


            services.AddScoped<IBaseRepository<Transacao>, BaseRepository<Transacao>>();
            services.AddScoped<IBaseService<Transacao>, BaseService<Transacao>>();

            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Usuario, UsuarioMap>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Cidade, Cidade>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Cliente, Cliente>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Transacao, Transacao>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<Consulta, Consulta>(); }).CreateMapper());
            services.AddSingleton(new MapperConfiguration(config => { config.CreateMap<ClassificacaoTransacao, ClassificacaoTransacao>(); }).CreateMapper());



            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestUsuario()
        {
            var sp = ConfiguraServices();
            var _userService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Murilo",
                Login = "MuriloVarges",
                Email = "murilo@mail.com",
                Senha = "123",
                DataCadastro = DateTime.Now,
                DataLogin = DateTime.Now
            };

            var result = _userService?.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestCidade()
        {
            var sp = ConfiguraServices();
            var _cidadeService = sp.GetService<IBaseService<Cidade>>();
            var cidade = new Cidade
            {
                Nome = "Araçatuba",
                Estado = "Sp",
            };

            var result = _cidadeService?.Add<Cidade, Cidade, CidadeValidator>(cidade);
            Console.WriteLine(JsonSerializer.Serialize(cidade));
        }

        [TestMethod]
        public void TestCliente()
        {
            var sp = ConfiguraServices();
            var _clienteService = sp.GetService<IBaseService<Cliente>>();

            var _cidadeService = sp.GetService<IBaseService<Cidade>>();

            var cidade = _cidadeService?.GetById<Cidade>(2);


            var cliente = new Cliente
            {
                Bairro = "Pq baguaçu",
                Cidade = cidade,
                Cpf = "42412899900",
                Endereco = "R Jose do couto moraes, 191",
                Nome = "Jeffin do Grau",
                Telefone = "1899291000"
                
            };

            var result = _clienteService?.Add<Cliente, Cliente, ClienteValidator>(cliente);
            Console.WriteLine(JsonSerializer.Serialize(cliente));
        }


        [TestMethod]
        public void TestConsulta()
        {
            var sp = ConfiguraServices();
            var _consultaService = sp.GetService<IBaseService<Consulta>>();

            var _userService = sp.GetService<IBaseService<Usuario>>();
            var _cliService = sp.GetService<IBaseService<Cliente>>();

            
            var advogado = _userService?.GetById<Usuario>(1);

            var includes = new List<String>() { "Cidade" };
            var cliente = _cliService?.GetById<Cliente>(2, includes);

            var consulta = new Consulta
            {
                Data = DateTime.UtcNow.ToLocalTime(),
                Advogado = advogado,
                Cliente = cliente

            };

            var result = _consultaService?.Add<Consulta, Consulta, ConsultaValidator>(consulta);
            Console.WriteLine(JsonSerializer.Serialize(consulta));
        }

        [TestMethod]
        public void TestTransacao()
        {
            var sp = ConfiguraServices();
            var _transacaoService = sp.GetService<IBaseService<Transacao>>();

            var _userService = sp.GetService<IBaseService<Usuario>>();
            var _classificaTransacaoService = sp.GetService<IBaseService<ClassificacaoTransacao>>();


            var advogado = _userService?.GetById<Usuario>(1);
            var classificacaoT = _classificaTransacaoService?.GetById<ClassificacaoTransacao>(1);


            var transacao = new Transacao
            {
                Advogado = advogado,
                ClassificacaoTransacao = classificacaoT,
                DataTransacao = DateTime.UtcNow.ToLocalTime(),
                TipoTransacao = false,
                Valor = 500.15F

            };

            var result = _transacaoService?.Add<Transacao, Transacao, TransacaoValidator>(transacao);
            Console.WriteLine(JsonSerializer.Serialize(transacao));
        }

        [TestMethod]
        public void TestClassificaTransacao()
        {
            var sp = ConfiguraServices();
            var _classificaTransacaoService = sp.GetService<IBaseService<ClassificacaoTransacao>>();


            //false = despesa
            //true = receita
            var classificacaoTransacao = new ClassificacaoTransacao
            {
                CodAgrupamento = "100",
                NomeAgrupamento = "Despesas Fixas Escritório",
                Tipo = false

            };

            var result = _classificaTransacaoService?.Add<ClassificacaoTransacao, ClassificacaoTransacao, ClassificacaoTransacaoValidator>(classificacaoTransacao);
            Console.WriteLine(JsonSerializer.Serialize(classificacaoTransacao));
        }
    }
}

