using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TextMatch.Controllers;
using TextMatch.ViewModels;

namespace TextMatch.Tests
{
    [TestClass]
    public class MatchStringControllerTests
    {
        [TestMethod]
        public void FindMatchesTest_InvalidModel()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void FindMatchesTest_SubtextLongetThanText()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void FindMatchesTest_Success()
        {
            //Mocked services
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindMatchesTest_Exception()
        {
            Assert.Fail();
        }
    }
}
