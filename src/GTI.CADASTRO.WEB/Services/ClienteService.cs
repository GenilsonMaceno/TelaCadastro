using GTI.CADASTRO.BUSINESSLOGIC.Helpers;
using GTI.CADASTRO.WEB.App_Config;
using GTI.CADASTRO.WEB.Models;
using GTI.CADASTRO.WEB.Services.Interface;
using GTI.CADASTRO.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GTI.CADASTRO.WEB.Services
{
    public class ClienteService : IClienteService
    {
        private readonly string _endpointIncluir = "/cliente/incluir";

        public async Task IncluirCliente(ClienteViewModel viewModel)
        {
            try
            {
                var endpoint = string.Concat(ConfigSettings.EndPointApi, _endpointIncluir);

                var cliente = new Cliente()
                {
                    CPF = viewModel.CPF,
                    DataExpedicao = viewModel.DataExpedicao,
                    Nome = viewModel.Nome,
                    EstadoCivil = viewModel.EstadoCivil,
                    Sexo = viewModel.Sexo,
                    RG = viewModel.RG,
                    UF = viewModel.UFExpedicao,
                    Endereco = new Endereco
                    {
                        Bairro = viewModel.Bairro,
                        UF = viewModel.UF,
                        CEP = viewModel.CEP,
                        Cidade = viewModel.Cidade,
                        Complemento = viewModel.Complemento,
                        Logradouro = viewModel.Logradouro,
                        Numero = viewModel.Numero
                    }
                };

                await HttpUtils.ExecutePostAsync(endpoint, cliente);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}