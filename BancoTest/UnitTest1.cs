using API_DTE.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoTest
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
    }
}
