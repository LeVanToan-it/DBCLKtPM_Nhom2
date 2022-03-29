using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    [TestClass]
    public class utLab1
    {
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
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            //String max = Convert.ToString(TestContext.DataRow["max"]);
            int a = Convert.ToInt32(TestContext.DataRow["A"]);
            int b = Convert.ToInt32(TestContext.DataRow["B"]);
            int c = Convert.ToInt32(TestContext.DataRow["C"]);
            String expectedResult = Convert.ToString(TestContext.DataRow["Max"]);
            String actualResult = Convert.ToString(methodLibrary.Max(a, b, c));
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}