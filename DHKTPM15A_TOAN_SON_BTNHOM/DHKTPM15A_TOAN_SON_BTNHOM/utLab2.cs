using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    /// <summary>
    /// Summary description for utLab2
    /// </summary>
    [TestClass]
    public class utLab2
    {
        public utLab2()
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
            String expectedResult = "Có 2 nghiệm phân biệt";
            float x1 = 2;
            float x2 = -3;
            String actualResult = methodLibrary.SolveQuadratic(1, 1, -6, out x1, out x2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String expectedResult = "Vô nghiệm";
            float x1 = float.NaN;
            float x2 = float.NaN;
            String actualResult = methodLibrary.SolveQuadratic(0, 0, -6, out x1, out x2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String expectedResult = "Vô số nghiệm";
            float x1 = float.NaN;
            float x2 = float.NaN;
            String actualResult = methodLibrary.SolveQuadratic(0, 0, 0, out x1, out x2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String expectedResult = "Có nghiệm kép";
            float x1 = 1;
            float x2 = 1;
            String actualResult = methodLibrary.SolveQuadratic(1, -2, 1, out x1, out x2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String expectedResult = "Có 1 nghiệm";
            float x1 = 6;
            float x2 = 6;
            String actualResult = methodLibrary.SolveQuadratic(0, 1, -6, out x1, out x2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary2 = new MethodLibrary.MethodLibrary();
                float x1 = 0;
                float x2 = 0;
                String actualResult = methodLibrary2.SolveQuadratic(Convert.ToInt32("a"), -2, 1, out x1, out x2);
            }catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary2 = new MethodLibrary.MethodLibrary();
                float x1 = 0;
                float x2 = 0;
                String actualResult = methodLibrary2.SolveQuadratic(3,Convert.ToInt32("b"), 1, out x1, out x2);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary2 = new MethodLibrary.MethodLibrary();
                float x1 = 0;
                float x2 = 0;
                String actualResult = methodLibrary2.SolveQuadratic(3,-2,Convert.ToInt32("a"), out x1, out x2);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }
    }
}
