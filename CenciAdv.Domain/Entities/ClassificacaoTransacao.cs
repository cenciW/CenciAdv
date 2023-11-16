using CenciAdv.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.Domain.Entities
{
    public class ClassificacaoTransacao : BaseEntity<int>
    {
        public string? CodigoTransacao { get; set; }
        public string? NomeAgrupamento { get; set; }
        public bool Tipo { get; set; }

        public ClassificacaoTransacao()
        {

        }

        public ClassificacaoTransacao(int id, string codTransacao, string nomeAgrupamento, bool tipo)
        {
            CodigoTransacao= codTransacao;
            NomeAgrupamento= nomeAgrupamento;
            Tipo = tipo;
        }
    }
}
