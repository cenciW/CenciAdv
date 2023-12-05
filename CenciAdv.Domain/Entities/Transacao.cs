using CenciAdv.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.Domain.Entities
{

    public class Transacao : BaseEntity<int>
    {
        public Transacao() { }
        public Transacao(int id, float valor, DateTime dataTransacao, bool tipoTransacao, Usuario? advogado, ClassificacaoTransacao? ct, string descricaoTransacao)
        {
            Valor = valor;
            DataTransacao = dataTransacao;
            TipoTransacao = tipoTransacao;
            Advogado = advogado;
            ClassificacaoTransacao= ct;
            DescricaoTransacao = descricaoTransacao;

        }
        public string DescricaoTransacao { get; set; }
        public float Valor { get; set; }
        public DateTime? DataTransacao { get; set; }
        //1 - Receita
        //0 - Despesa
        public bool TipoTransacao { get; set; }
        public Usuario? Advogado { get; set; }
        public ClassificacaoTransacao? ClassificacaoTransacao { get; set; }
    }
}
