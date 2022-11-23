using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GTI.CADASTRO.WEB.ViewModels
{
    public class EnderecoViewModel
    {
        public decimal EnderecoId { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}