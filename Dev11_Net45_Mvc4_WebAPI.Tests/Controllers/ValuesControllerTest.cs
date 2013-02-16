using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dev11_Net45_Mvc4_WebAPI;
using Dev11_Net45_Mvc4_WebAPI.Controllers;

namespace Dev11_Net45_Mvc4_WebAPI.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IQueryable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("Hello", result.ElementAt(0));
            Assert.AreEqual("World", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("Hello World!", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            var result = controller.Post("value");

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}
