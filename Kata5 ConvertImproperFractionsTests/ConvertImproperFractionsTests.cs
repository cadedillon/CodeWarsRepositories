using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertImproperFractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertImproperFractions.Tests
{
    [TestClass()]
    public class ConvertImproperFractionsTests
    {
        [TestMethod()]
        public void MixedFractionTest1()
        {
            Assert.AreEqual("4 2/3", ConvertImproperFractions.MixedNumberFx("42/9"));
            Assert.AreEqual("2", ConvertImproperFractions.MixedNumberFx("6/3"));
        }

        [TestMethod()]
        public void MixedFractionTest2()
        {
            Assert.AreEqual("1", ConvertImproperFractions.MixedNumberFx("1/1"));
            Assert.AreEqual("1", ConvertImproperFractions.MixedNumberFx("11/11"));
        }

        [TestMethod()]
        public void MixedFractionTest3()
        {
            Assert.AreEqual("2/3", ConvertImproperFractions.MixedNumberFx("4/6"));
            Assert.AreEqual("0", ConvertImproperFractions.MixedNumberFx("0/18891"));
        }

    }
}