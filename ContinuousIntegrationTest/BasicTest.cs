using ContinuosDeployment.Controllers;
using ContinuosDeployment.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ContinuousIntegrationTest
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void ValidateModel()
        {
            var model = new Test();

            model.MyProperty = new string[] { "Test1", "Test2" };

            Assert.AreEqual(model.MyProperty.Count(), 2);
        }

        [TestMethod]
        public void ValidateController()
        {
            var controller = new TestController();

            var go = controller.Go();

            Assert.IsNotNull(go);
            Assert.AreEqual(go.Count(), 2);
        }
    }
}
