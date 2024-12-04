﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roadmap_dotnet.Mocking
{
    public class Pendencia
    {
        public string? CPF { get; set; }
        public string? NomePessoa { get; set; }
        public string? NomeReclamante { get; set; }
        public string? DescricaoPendencia { get; set; }
        public DateTime DataPendencia { get; set; }
        public double VlPendencia { get; set; }
    }
}
