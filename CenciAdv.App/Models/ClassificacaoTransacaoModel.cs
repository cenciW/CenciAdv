using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.App.Models
{
    public class ClassificacaoTransacaoModel
    {
        public int Id { get; set; }
        public string? CodAgrupamento { get; set; }
        public string? NomeAgrupamento { get; set; }
        public string Tipo { get; set; }
    }
}
