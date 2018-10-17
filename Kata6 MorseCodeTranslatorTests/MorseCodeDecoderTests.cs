using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCodeTranslator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator.Tests
{
    [TestClass()]
    public class MorseCodeDecoderTests
    {
        [TestMethod()]
        public void DecodeTest1()
        {
            Assert.AreEqual("HEY JUDE", MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. ."));
        }


        [TestMethod()]
        public void DecodeTest2()
        {
            Assert.AreEqual("HELLO WORLD", MorseCodeDecoder.Decode(".... . .-.. .-.. ---   .-- --- .-. .-.. -.."));
        }
    }
}