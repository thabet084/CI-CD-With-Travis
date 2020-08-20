using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TravisDemo.UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int x = 5;

            //Act

            //Assert
            Assert.AreEqual(5,x);
        }
    }
}
