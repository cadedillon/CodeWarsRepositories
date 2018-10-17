using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindOddInteger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOddInteger.Tests
{
    [TestClass()]
    public class FindOddIntegerTests
    {
        [TestMethod()]
        public void FindItFxTest()
        {
            Assert.AreEqual(5, FindOddInteger.FindItFx( new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 } ));
        }
    }
}