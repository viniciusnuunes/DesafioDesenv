using DesafioDesenv.Models;
using DesafioDesenv.Repository;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DesafioDesenv.Controllers
{
    public class ClienteController : Controller
    {
        public DataContext contexto = new DataContext();        

        // GET: Cliente
        public ActionResult Index()
        {
            return View(contexto.Clientes.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var clientEdit = (from c in contexto.Clientes
                              where c.clienteID == id
                              select c).FirstOrDefault();

            return View(clientEdit);
        }

        [HttpPost]
        public ActionResult Edit(Cliente cliente, int id)
        {
            if (ModelState.IsValid)
            {
                contexto.Entry(cliente).State = EntityState.Modified;
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(Cliente cliente, int id)
        {
            var clienteDetails = (from c in contexto.Clientes
                                  where c.clienteID == id
                                  select c).FirstOrDefault();
            return View(clienteDetails);
        }

        public ActionResult Delete(int id)
        {
            var clienteDelete = (from c in contexto.Clientes
                                 where c.clienteID == id
                                 select c).FirstOrDefault();
            return View(clienteDelete);
        }

        [HttpPost]
        public ActionResult Delete(Cliente cliente, int id)
        {
            try
            {
                var clienteDelete = contexto.Clientes.Find(id);
                contexto.Clientes.Remove(clienteDelete);
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }            
        }

        protected override void Dispose(bool disposing)
        {
            contexto.Dispose();
            base.Dispose(disposing);
        }
    }
}