using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioDesenv.Controllers;
using System.Web.Mvc;
using DesafioDesenv.Models;
using Moq;
using DesafioDesenv.Repository;

namespace DesafioDesenv.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateTestMethod()
        {
            var MockRepository = new Mock<DataContext>();
            var controller = new ClienteController(MockRepository.Object);

            var clienteCreate = new Cliente()
            {
                clienteID = 1,
                Nome = "Vinicius",
                Sobrenome = "Nunes",
                dataDeNascimento = "1993/07/22",
                Email = "teste@teste.com.br",
                Telefone = 980346645
            };

            var result = controller.Create(clienteCreate);

            Assert.AreEqual("Create", result.ViewName);
        }
    }
}
