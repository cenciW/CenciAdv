using CenciAdv.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.App.Models
{
    public class ConsultaModel
    {
        public ConsultaModel()
        {
                
        }
        public int Id { get; set; }

        public DateTime? Data { get; set; }
        public int IdAdvogado { get; set; }
        public string? NomeAdvogado { get;set; }
        public int IdCliente { get; set; }
        public string? NomeCliente { get; set; }

    }
}
