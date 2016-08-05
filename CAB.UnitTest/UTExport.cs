using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB.Interface;
using CAB.ExportLibrary;

namespace CAB.UnitTest
{
    [TestClass]
    public class UTExport
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        
        /// <summary>
        ///A test for ExportTo
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException))]
        public void ExportToTest()
        {
            var target = new Export(); // TODO: Initialize to an appropriate value
            var expected = false;
            var actual = target.ExportTo(Options.TEXT, null);            
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

    }
}
