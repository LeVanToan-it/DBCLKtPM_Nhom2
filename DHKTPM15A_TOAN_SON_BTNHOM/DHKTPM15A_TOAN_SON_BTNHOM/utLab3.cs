using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    /// <summary>
    /// Summary description for utLab3
    /// </summary>
    [TestClass]
    public class utLab3
    {
        public utLab3()
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
            int chiSoCu = 10;
            int chiSoMoi = 20;
            double expectedResult = 16324;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 0;
            int chiSoMoi = 0;
            double expectedResult = 0;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 15;
            int chiSoMoi = 16;
            double expectedResult = 1632.4;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 10;
            int chiSoMoi = 60;
            double expectedResult = 74198.9;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 10;
            int chiSoMoi = 110;
            double expectedResult = 168630;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 10;
            int chiSoMoi = 210;
            double expectedResult = 392920;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 10;
            int chiSoMoi = 310;
            double expectedResult = 739860;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod8()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 10;
            int chiSoMoi = 410;
            double expectedResult = 1101320;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod9()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 10;
            int chiSoMoi = 510;
            double expectedResult = 1422850;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod10()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = -5;
            int chiSoMoi = 20;
            double expectedResult = -1;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod11()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = -1;
            int chiSoMoi = 20;
            double expectedResult = -1;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod12()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 20;
            int chiSoMoi = 0;
            double expectedResult = -1;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod13()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int chiSoCu = 20;
            int chiSoMoi = 19;
            double expectedResult = -1;
            double actualResult = methodLibrary.TinhTienDien(chiSoCu, chiSoMoi);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
