using Login.Libraries.Login;
using Login.Models;
using Login.Repository.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login.Controllers
{
    public class HomeController : Controller
    {
        private IClienteRepositiry _clienteRepositiry;
        private LoginCliente _loginCliente;

        public HomeController(IClienteRepositiry clienteRepositiry, LoginCliente loginCliente)
        {
            _clienteRepositiry = clienteRepositiry;
            _loginCliente = loginCliente;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([FromForm] Cliente cliente)
        {
            Cliente clienteDB = _clienteRepositiry.Login(cliente.Email, cliente.Senha);

            if (clienteDB.Email != null && clienteDB.Senha != null)
            {
                _loginCliente.Login(clienteDB);
                return new RedirectResult(Url.Action(nameof(PainelCliente)));
            }
            else
            {
                ViewData["MSG_E"] = "Usuario não localizado, por favor verifique e-mail e senha digitado";
                return View();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PainelCliente()
        {
            ViewBag.Nome = _loginCliente.GetCliente().Name;
            ViewBag.CPF = _loginCliente.GetCliente().CPF;
            ViewBag.Email = _loginCliente.GetCliente().Email;
            return View();
        }

        public IActionResult LogoutCliente()
        {
            _loginCliente.Logout();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
