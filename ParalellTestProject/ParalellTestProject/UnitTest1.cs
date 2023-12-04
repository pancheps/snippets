[assembly: Parallelize(Workers = 5, Scope = ExecutionScope.MethodLevel)]
namespace ParalellTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [DoNotParallelize]
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToGoogle());
        }

        [TestMethod]
        public void TestMethod2()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToCabrajeta());
        }

        [TestMethod]
        public void TestMethod3()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToTwitter());
        }

        [TestMethod]
        public void TestMethod4()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToFacebook());
        }

        [TestMethod]
        public void TestMethod5()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToGoogle());
        }
        [TestMethod]
        public void TestMethod6()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToCabrajeta());
        }
        [TestMethod]
        public void TestMethod7()
        {
            var c = new Common();
            Assert.IsTrue(c.GoToTwitter());
        }
    }
}