using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TextMatch.Service;

namespace TextMatch.Tests
{
    [TestClass]
    public class StringMatchTests
    {
        [TestMethod]
        public void FindMatchText_Success()
        {
            const string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all havetea";
            const string subtext = "Polly";
            const string output = "1,26,51";

            var service = new StringMatchService();
            var result = service.FindMatchText(text, subtext);

            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void FindMatchText_Success2()
        {
            const string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all havetea";
            const string subtext = "ll (ell ell)";
            const string output = "3,28,53,78,82";

            var service = new StringMatchService();
            var result = service.FindMatchText(text, subtext);

            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void FindMatchText_Success3()
        {
            const string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all havetea";
            const string subtext = "X";
            const string output = "";

            var service = new StringMatchService();
            var result = service.FindMatchText(text, subtext);

            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void FindMatchText_Success4()
        {
            const string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all havetea";
            const string subtext = "Polx";
            const string output = "";

            var service = new StringMatchService();
            var result = service.FindMatchText(text, subtext);

            Assert.AreEqual(output, result);
        }
    }
}
