using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakCamelCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakCamelCase.Tests
{
    [TestClass()]
    public class BreakCamelCaseTests
    {
        [TestMethod()]
        public void BreakCamelFxTest1()
        {
            Assert.AreEqual("broke My Camel Case", BreakCamelCase.BreakCamelFx("brokeMyCamelCase"));
        }

        [TestMethod()]
        public void BreakCamelFxTest2()
        {
            Assert.AreEqual("it's Like Magic", BreakCamelCase.BreakCamelFx("it'sLikeMagic"));
        }
    }
}