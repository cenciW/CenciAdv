using CenciAdv.Domain.Base;


namespace CenciAdv.Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {
        public Consulta()
        {
            
        }

        public Consulta(int id, DateTime? data, Usuario? advogado, Cliente? cliente, string hora) : base(id)
        {
            Data = data;
            Advogado = advogado;
            Cliente = cliente;
            HoraConsulta = hora;
        }

        public string HoraConsulta { get; set; }
        public DateTime? Data { get; set; }
        public Usuario? Advogado { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
