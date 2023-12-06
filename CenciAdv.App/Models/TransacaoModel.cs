using CenciAdv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.App.Models
{
    public class TransacaoModel
    {
        public int Id { get; set; }
        public float Valor { get; set; }
        public DateTime? DataTransacao { get; set; }
        //1 - Receita
        //0 - Despesa
        public bool TipoTransacao { get; set; }
        public string DescricaoTransacao { get; set; }
        //public Usuario? Advogado { get; set; }
        public int IdAdvogado { get; set; }
        public string? NomeAdvogado { get; set; }
        //public ClassificacaoTransacao? ClassificacaoTransacao { get; set; }
        public string? CodAgrupamento { get; set; }
        public string? NomeAgrupamento { get; set; }
        public bool TipoAgrupamento { get; set; }
        public string? TipoTransacaoTxt { get; set; }

    }
}
