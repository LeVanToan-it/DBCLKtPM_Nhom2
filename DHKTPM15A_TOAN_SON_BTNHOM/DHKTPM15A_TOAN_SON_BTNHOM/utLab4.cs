using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    /// <summary>
    /// Summary description for utLab4
    /// </summary>
    [TestClass]
    public class utLab4
    {
        public utLab4()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = 0;
            long s = 6;
            long k = 0;
            long actualResult = methodLibrary.Sum(s0,out s);

            Assert.AreEqual(k, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = 20;
            long s = 21;
            long k = 6;
            long actualResult = methodLibrary.Sum(s0, out s);

            Assert.AreEqual(k, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = -1;
            long s = 6;
            long k = 0;
            long actualResult = methodLibrary.Sum(s0, out s);

            Assert.AreEqual(k, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            long s0 = 1;
            long s = 6;
            long k = 0;
            long actualResult = methodLibrary.Sum(s0, out s);

            Assert.AreEqual(k, actualResult);
        }
    }
}
