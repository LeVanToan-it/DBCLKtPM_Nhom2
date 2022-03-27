using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    [TestClass]
    public class utLab5 {
        public utLab5()
        {
            //Nothing
        }
        public TestContext TestContext
        {
            get;
            set;
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_bai5.csv", "data_bai5#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_bai5.csv"), TestMethod]
        public void Bai5_TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s = Convert.ToString(TestContext.DataRow["s"]);
            int n = Convert.ToInt32(TestContext.DataRow["n"]);
            int p = Convert.ToInt32(TestContext.DataRow["p"]);
            String expectedResult = Convert.ToString(TestContext.DataRow["ketQua"]);
            String actualResult = methodLibrary.HuyChuoi(s,n,p);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }

}
