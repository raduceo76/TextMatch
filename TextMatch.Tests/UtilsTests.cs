using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextMatch.Utils;

namespace TextMatch.Tests
{

    [TestClass]
    public class UtilsTests
    {
        [TestMethod]
        public void ToCharArray_Success()
        {
            const string inString = "test";
            var resultArr = Utility.ToCharArray(inString);

            Assert.IsNotNull(resultArr);
            Assert.IsTrue(resultArr.GetType() == typeof(char[]));
            Assert.AreEqual(resultArr.Length, inString.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ToCharArray_Fail()
        {
            const string inString = null;
            var resultArr = Utility.ToCharArray(inString);
        }
    }

}
