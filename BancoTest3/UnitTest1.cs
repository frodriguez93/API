using API_DTE.Controllers;
using API_DTE.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoTest3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var banco = new BancoRepository();
            var bancoController = new BancoController(banco);

            var result = bancoController.GetAsync(1).Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetAsyncReturnsNotFound()
        {
            var banco = new BancoRepository();
            var bancoController = new BancoController(banco);

            var result = bancoController.GetAsync(100).Result; 
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}
