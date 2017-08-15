using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioDesenv.Controllers;
using System.Web.Mvc;
using DesafioDesenv.Models;
using Moq;
using DesafioDesenv.Repository;
using System.Data.Entity;

namespace DesafioDesenv.Test
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void IndexTestMethod()
        //{
        //    var mockSet = new Mock<DbSet<Cliente>>();
        //    var mockContext = new Mock<DataContext>();
        //    mockContext.Setup(c => c.Clientes).Returns(mockSet.Object);

        //    var service = new DataService(mockContext.Object);
        //    var cliente = service.GetClients();

        //    Assert.AreEqual(4, cliente.Count);
        //}

        //[TestMethod]
        //public void CreateTesteMethod()
        //{
        //    var controller = new ClienteController();
        //    var cliente = new Cliente()
        //    {
        //        clienteID = 1,
        //        Nome = "Vinicius",
        //        Sobrenome = "Nunes",
        //        dataDeNascimento = "1993/07/22",
        //        Email = "teste@teste.com.br",
        //        Telefone = 980346645
        //    };
        //    var result = controller.Create(cliente);

        //    Assert.IsInstanceOfType(result, typeof(ViewResult));
        //    RedirectToRouteResult routeResult = result as RedirectToRouteResult;
        //    Assert.AreEqual(routeResult.RouteValues["Index"], result);
        //}

        //[TestMethod]
        //public void IndexTestMethod()
        //{
        //    var mockSet = new Mock<DbSet<Cliente>>();
        //    var mockContext = new Mock<DataContext>();

        //    mockContext.Setup(c => c.Clientes).Returns(mockSet.Object);

        //    var service = new DataService(mockContext.Object);
        //    service.SaveClients(new Cliente()
        //    {
        //        clienteID = 1,
        //        Nome = "Vinicius",
        //        Sobrenome = "Nunes",
        //        dataDeNascimento = "1993/07/22",
        //        Email = "teste@teste.com.br",
        //        Telefone = 980346645
        //    });

        //    mockSet.Verify(c => c.Add(It.IsAny<Cliente>()), Times.Once());
        //    mockContext.Verify(c => c.SaveChanges(), Times.Once());
        //}
    }
}
