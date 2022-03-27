using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    [TestClass]
    public class utLab6 {
        public utLab6()
        {
            //Nothing
        }
        public TestContext TestContext
        {
            get;
            set;
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_bai6.csv", "data_bai6#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_bai6.csv"), TestMethod]
        public void Bai5_TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            String s1 = Convert.ToString(TestContext.DataRow["s1"]);
            String s2 = Convert.ToString(TestContext.DataRow["s2"]);
            String s3 = Convert.ToString(TestContext.DataRow["s3"]);
            String expectedResult = Convert.ToString(TestContext.DataRow["ketQua"]);
            String actualResult = methodLibrary.ThayThe(s1,s2,s3);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }

}
