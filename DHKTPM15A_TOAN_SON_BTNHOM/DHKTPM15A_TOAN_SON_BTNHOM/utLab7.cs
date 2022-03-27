using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM15A_TOAN_SON_BTNHOM
{
    [TestClass]
    public class utLab7 {
        public utLab7()
        {
            //Nothing
        }
        public TestContext TestContext
        {
            get;
            set;
        }


        [TestMethod]
        public void Bai7_TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 5, 7, 8, 4 };
            int expectedResult = 8;
            int actualResult = methodLibrary.Largest(a);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Bai7_TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { };
            int expectedResult = int.MaxValue;
            int actualResult = methodLibrary.Largest(a);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}
