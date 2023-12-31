﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenciAdv.App.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public int CidadeId { get; set; }
        public string? NomeCidade { get; set; }
        public string? NomeFone { get; set; }
    }
}
