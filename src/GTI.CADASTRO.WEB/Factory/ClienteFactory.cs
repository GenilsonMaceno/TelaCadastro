using GTI.CADASTRO.BUSINESSLOGIC.Helpers;
using GTI.CADASTRO.WEB.Factory.Interface;
using GTI.CADASTRO.WEB.Services.Interface;
using GTI.CADASTRO.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GTI.CADASTRO.WEB.Factory
{
    public class ClienteFactory : IClienteFactory
    {
        private readonly IClienteService _clienteService;

        public ClienteFactory(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public Task AtualizarCliente(ClienteViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirCliente(ClienteViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task IncluirCliente(ClienteViewModel viewModel)
        {
            try
            {
                await _clienteService.IncluirCliente(viewModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}