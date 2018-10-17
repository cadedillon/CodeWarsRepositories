using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertStringtoCamelCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringtoCamelCase.Tests
{
    [TestClass()]
    public class ConvertStringToCamelCaseTests
    {
        [TestMethod()]
        public void ToCamelCaseFxTest1()
        {
            Assert.AreEqual("theStealthWarrior", ConvertStringToCamelCase.ToCamelCaseFx("the_stealth_warrior"));
            Assert.AreEqual("TheStealthWarrior", ConvertStringToCamelCase.ToCamelCaseFx("The-Stealth-Warrior"));
        }

        [TestMethod()]
        public void ToCamelCaseFxTest2()
        {
            Assert.AreEqual("putThisInCamelCasePls", ConvertStringToCamelCase.ToCamelCaseFx("put-this-in-camel-case-pls"));
            Assert.AreEqual("PutThisInCamelCasePls", ConvertStringToCamelCase.ToCamelCaseFx("Put-this-in-camel-case-pls"));
        }

        [TestMethod()]
        public void ToCamelCaseFxTest3()
        {
            Assert.AreEqual("thx", ConvertStringToCamelCase.ToCamelCaseFx("thx"));
            Assert.AreEqual("Thx", ConvertStringToCamelCase.ToCamelCaseFx("Thx"));
        }

    }
}