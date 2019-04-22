using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.NetworkInformation;

namespace ContinuousIntegrationTest
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void CallApi()
        {
            var x = 1;

            Assert.AreEqual(x, 1);
        }
    }
}
