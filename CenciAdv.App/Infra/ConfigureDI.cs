using AutoMapper;
using CenciAdv.Domain.Base;
using CenciAdv.Domain.Entities;
using CenciAdv.Repository.Context;
using CenciAdv.Repository.Repository;
using CenciAdv.Service.Services;
using CenciAdv.App.Cadastros;
using CenciAdv.App.Models;
using CenciAdv.App.Outros;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CenciAdv.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DatabaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Transacao>, BaseRepository<Transacao>>();
            Services.AddScoped<IBaseRepository<ClassificacaoTransacao>, BaseRepository<ClassificacaoTransacao>>();
            Services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Transacao>, BaseService<Transacao>>();
            Services.AddScoped<IBaseService<ClassificacaoTransacao>, BaseService<ClassificacaoTransacao>>();
            Services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();

            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroTransacao, CadastroTransacao>();
            Services.AddTransient<CadastroTiposTransacao, CadastroTiposTransacao>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroConsulta, CadastroConsulta>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();

                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.NomeCidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.CidadeId, d => d.MapFrom(x => x.Cidade!.Id))
                    .ForMember(d => d.NomeFone, d => d.MapFrom(x => $"{x.Nome}/{x.Telefone}"));
                    

                config.CreateMap<ClassificacaoTransacao, ClassificacaoTransacaoModel>()
                .ForMember(d => d.Tipo, d => d.MapFrom(x => x.Tipo ? "Receita": "Despesa"));

                config.CreateMap<Transacao, TransacaoModel>()
                    .ForMember(d => d.IdAdvogado, d => d.MapFrom(x => x.Advogado!.Id))
                    .ForMember(d => d.NomeAdvogado, d => d.MapFrom(x => x.Advogado!.Nome))
                    .ForMember(d => d.CodAgrupamento, d => d.MapFrom(x => x.ClassificacaoTransacao!.CodAgrupamento))
                    .ForMember(d => d.NomeAgrupamento, d => d.MapFrom(x => x.ClassificacaoTransacao!.NomeAgrupamento))
                    .ForMember(d => d.TipoAgrupamento, d => d.MapFrom(x => x.ClassificacaoTransacao!.Tipo));

                config.CreateMap<Consulta, ConsultaModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.NomeCliente, d => d.MapFrom(x => x.Cliente!.Nome))
                    .ForMember(d => d.IdAdvogado, d => d.MapFrom(x => x.Advogado!.Id))
                    .ForMember(d => d.NomeAdvogado, d => d.MapFrom(x => x.Advogado!.Nome));

            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
