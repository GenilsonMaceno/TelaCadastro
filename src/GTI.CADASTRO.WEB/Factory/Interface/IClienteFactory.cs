using GTI.CADASTRO.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTI.CADASTRO.WEB.Factory.Interface
{
    public interface IClienteFactory
    {
        Task IncluirCliente(ClienteViewModel viewModel);
        Task AtualizarCliente(ClienteViewModel viewModel);
        Task ExcluirCliente(ClienteViewModel viewModel);
    }
}
