using DesafioDesenv.Models;
using DesafioDesenv.Repository;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace DesafioDesenv.Controllers
{
    public class ClienteController : Controller
    {
        public DataContext contexto = new DataContext();
        public DataService service = new DataService(new DataContext());

        // GET: Cliente
        public ActionResult Index()
        {
            return View(service.GetClients());
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        // GET
        public ActionResult Edit(int id)
        {
            var clientEdit = (from c in contexto.Clientes
                              where c.clienteID == id
                              select c).FirstOrDefault();

            return View(clientEdit);
        }

        // GET
        public ActionResult Details(int id)
        {
            var clienteDetails = (from c in contexto.Clientes
                                  where c.clienteID == id
                                  select c).FirstOrDefault();
            return View(clienteDetails);
        }

        // GET
        public ActionResult Delete(int id)
        {
            var clienteDelete = (from c in contexto.Clientes
                                 where c.clienteID == id
                                 select c).FirstOrDefault();
            return View(clienteDelete);
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.CreateClients(cliente);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Não foi possível criar no momento. Tente novamente.");
            }
            return View();
        }        

        [HttpPost]
        public ActionResult Edit(Cliente cliente, int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    service.EditClients(cliente, id);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "Não foi possível editar o cliente. Tente novamente.");
            }            
            return View();
        }
        
        [HttpPost]
        public ActionResult Delete(Cliente cliente, int id)
        {
            try
            {
                service.DeleteClientes(cliente, id);
                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Não foi possível deletar o cliente. Tente novamente.");
            }
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            contexto.Dispose();
            base.Dispose(disposing);
        }
    }
}