using GTI.CADASTRO.WEB.Models;
using GTI.CADASTRO.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.WEB.Services.Interface
{
    public interface IClienteService
    {
        Task IncluirCliente(ClienteViewModel viewModel);
    }
}
