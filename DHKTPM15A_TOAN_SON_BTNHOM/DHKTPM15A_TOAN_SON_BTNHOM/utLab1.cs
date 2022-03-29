using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    /// <summary>
    /// Summary description for utLab1
    /// </summary>
    [TestClass]
    public class utLab1
    {
        
        public utLab1()
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
            int expectedResult = 15;
            int actualResult = methodLibrary.Max(10, 5, 15);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int expectedResult = 15;
            int actualResult = methodLibrary.Max(1, 5, 15);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int expectedResult = 50;
            int actualResult = methodLibrary.Max(50, 5, 15);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int expectedResult = 15;
            int actualResult = methodLibrary.Max(10, 1, 15);
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int expectedResult = 50;
            int actualResult = methodLibrary.Max(10, 50, 15);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int expectedResult = 10;
            int actualResult = methodLibrary.Max(10, 5, 1);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod7()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int expectedResult = 50;
            int actualResult = methodLibrary.Max(10, 5, 50);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int actualResult = methodLibrary.Max(0, 5, 15);
            }catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod9()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int actualResult = methodLibrary.Max(51, 5, 15);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int actualResult = methodLibrary.Max(10, 0, 15);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod11()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int actualResult = methodLibrary.Max(10, 51, 15);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int actualResult = methodLibrary.Max(10, 5, 0);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }

        [TestMethod]
        public void TestMethod13()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int actualResult = methodLibrary.Max(10, 5, 51);
            }
            catch (Exception ex)
            {
                expectedResult = ex;
            }
            Assert.IsNotNull(expectedResult);
        }
        
        /*
        public utLab1()
        {
            //Nothing
        }
        public TestContext TestContext
        {
            get;
            set;
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_bai1.csv", "data_bai1#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_bai1.csv"), TestMethod]
        public void Bai1_TestMethod1()
        {
            Exception exception = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                //String s = Convert.ToString(TestContext.DataRow["s"]);
                int A = Convert.ToInt32(TestContext.DataRow["A"]);
                int B = Convert.ToInt32(TestContext.DataRow["B"]);
                int C = Convert.ToInt32(TestContext.DataRow["C"]);
                String expectedResult = Convert.ToString(TestContext.DataRow["Max"]);
                String actualResult = Convert.ToString(methodLibrary.Max(A, B, C));
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        */
    }
}
