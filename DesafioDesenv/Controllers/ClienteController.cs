using DesafioDesenv.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioDesenv.Controllers
{
    public class ClienteController : Controller
    {
        private DataContext contexto = new DataContext();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(contexto.Clientes.ToList());
        }
    }
}