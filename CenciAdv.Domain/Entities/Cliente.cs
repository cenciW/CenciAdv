using CenciAdv.Domain.Base;


namespace CenciAdv.Domain.Entities
{
    public class Cliente : BaseEntity<int>
    {
        public Cliente()
        {
            
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string endereco, string bairro, Cidade? cidade) : base(id)
        {
            Nome = nome;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
