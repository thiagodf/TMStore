using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMStore.Domain.StoreContext.Entities;

namespace TMStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Customer(
                "Thiago", 
                "Martins",
                "01827940166",
                "thiago@email.com",
                "199999999",
                "Rua dos developers, 1008");
        }
    }
}
