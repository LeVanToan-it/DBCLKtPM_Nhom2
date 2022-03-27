using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    [TestClass]
    public class utLab8 {
        public utLab8()
        {
            //Nothing
        }
        public TestContext TestContext
        {
            get;
            set;
        }


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_bai8.csv", "data_bai8#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_bai8.csv"), TestMethod]
        public void Bai8_TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] actualResult;
            int a1;
            // all null
            if (Convert.ToString(TestContext.DataRow["a1"]).Equals("") && Convert.ToString(TestContext.DataRow["a2"]).Equals("") && Convert.ToString(TestContext.DataRow["a3"]).Equals("") && Convert.ToString(TestContext.DataRow["a4"]).Equals(""))
                actualResult = new int[] { };
            // a2, a3, a4 null
            else if(Convert.ToString(TestContext.DataRow["a2"]).Equals("") && Convert.ToString(TestContext.DataRow["a3"]).Equals("") && Convert.ToString(TestContext.DataRow["a4"]).Equals(""))
            {
                a1 = Convert.ToInt32(TestContext.DataRow["a1"]);
                actualResult = new int[] { a1 };
            }               
            else
            {
                a1 = Convert.ToInt32(TestContext.DataRow["a1"]);
                int a2 = Convert.ToInt32(TestContext.DataRow["a2"]);
                int a3 = Convert.ToInt32(TestContext.DataRow["a3"]);
                int a4 = Convert.ToInt32(TestContext.DataRow["a4"]);
                actualResult = new int[] { a1, a2, a3, a4 };
            }
            int left = Convert.ToInt32(TestContext.DataRow["left"]);
            int right = Convert.ToInt32(TestContext.DataRow["right"]);
            int[] expectedResult;
            int kq1;
            // all null
            if (Convert.ToString(TestContext.DataRow["kq1"]).Equals("") && Convert.ToString(TestContext.DataRow["kq2"]).Equals("") && Convert.ToString(TestContext.DataRow["kq3"]).Equals("") && Convert.ToString(TestContext.DataRow["kq4"]).Equals(""))
                expectedResult = new int[] { };
            // kq2, kq3, kq4 null
            else if (Convert.ToString(TestContext.DataRow["kq2"]).Equals("") && Convert.ToString(TestContext.DataRow["kq3"]).Equals("") && Convert.ToString(TestContext.DataRow["kq4"]).Equals(""))
            {
                kq1 = Convert.ToInt32(TestContext.DataRow["kq1"]);
                expectedResult = new int[] { kq1 };
            }
            else
            {
                kq1 = Convert.ToInt32(TestContext.DataRow["kq1"]);
                int kq2 = Convert.ToInt32(TestContext.DataRow["kq2"]);
                int kq3 = Convert.ToInt32(TestContext.DataRow["kq3"]);
                int kq4 = Convert.ToInt32(TestContext.DataRow["kq4"]);
                expectedResult = new int[] { kq1, kq2, kq3, kq4 };
            }
            methodLibrary.QuickSort(actualResult, left,right);
            compareArray(actualResult, expectedResult);
        }


        //Exception
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
          "|DataDirectory|\\data_bai8_exc.csv", "data_bai8_exc#csv",
          DataAccessMethod.Sequential),
          DeploymentItem("data_bai8_exc.csv"), TestMethod]
        public void Bai8_TestMethod2()
        {
            Exception expectedException = null;
            try
            {
                int a1 = Convert.ToInt32(TestContext.DataRow["a1"]);
                int a2 = Convert.ToInt32(TestContext.DataRow["a2"]);
                int a3 = Convert.ToInt32(TestContext.DataRow["a3"]);
                int a4 = Convert.ToInt32(TestContext.DataRow["a4"]);
                int[] actualResult = new int[] { a1, a2, a3, a4 };
                int left = Convert.ToInt32(TestContext.DataRow["left"]);
                int right = Convert.ToInt32(TestContext.DataRow["right"]);
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                methodLibrary.QuickSort(actualResult, left, right);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        public void compareArray(int[] a,int[] b)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    Assert.Fail("Expected: a["+i+"]= "+a[i]+ ", but Actual: b[" + i + "]= "+b[i]);
            }
            Assert.AreEqual(1,1);
        }

    }

}
