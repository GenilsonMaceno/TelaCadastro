using GTI.CADASTRO.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GTI.CADASTRO.WEB.ViewModels
{
    public class ClienteViewModel
    {
        public decimal ClienteId { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public DateTime DataExpedicao { get; set; }
        public string UF { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }

    }
}