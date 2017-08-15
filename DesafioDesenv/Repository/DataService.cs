using DesafioDesenv.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesafioDesenv.Repository
{
    public class DataService
    {        

        private DataContext contexto { get; set; }

        public DataService(DataContext context)
        {
            contexto = context;
        }        

        public List<Cliente> GetClients()
        {
            return contexto.Clientes.ToList();
        }        

        public void AddClients(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void EditClients(Cliente cliente, int id)
        {
            contexto.Entry(cliente).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void DeleteClientes(Cliente cliente, int id)
        {
            var clienteDelete = contexto.Clientes.Find(id);
            contexto.Clientes.Remove(clienteDelete);
            contexto.SaveChanges();
        }
    }
}