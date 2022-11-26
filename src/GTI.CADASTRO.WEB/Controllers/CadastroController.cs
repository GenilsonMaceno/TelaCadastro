using GTI.CADASTRO.WEB.Factory.Interface;
using GTI.CADASTRO.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace GTI.CADASTRO.WEB.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IClienteFactory _clienteFactory;

        public CadastroController(IClienteFactory clienteFactory)
        {
            _clienteFactory = clienteFactory;
        }

        // GET: Cadastro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Cliente(ClienteViewModel viewModel)
        {
            await _clienteFactory.IncluirCliente(viewModel);

            return View();
        }
    }
}