using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoClientes.Controllers
{
    public class ConsultaCepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
