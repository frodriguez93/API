using API_DTE.Controllers;
using API_DTE.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBanco
{
    [TestClass]
    public class BancoTest
    {
        [TestMethod]
        public void GetAsyncReturnsOk()
        {
            var banco = new BancoRepository();
            var bancoController = new BancoController(banco);

            var result = bancoController.GetAsync(1).Result;

        }
    }
}
