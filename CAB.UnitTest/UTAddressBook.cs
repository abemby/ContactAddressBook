using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CAB.Interface;
using CAB.ClassLibrary;
using System.Collections.Generic;

namespace CAB.UnitTest
{
    [TestClass]
    public class UTAddressBook
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        /// <summary>
        /// simple test - return type should be list of contacts...
        /// </summary>
        [TestMethod()]
        public void FindByFirstNameTest()
        {
            var target = new AddressBook(new CAB.ConsoleLogger.ConsoleLogger()); 
            string firstName = string.Empty;
            var expected = new List<IContact>();
            List<IContact> actual = target.FindByFirstName(firstName);
            Assert.AreEqual(expected.GetType(), actual.GetType());            
        }

        /// <summary>
        /// simple test - return type should be list of contacts...
        /// </summary>
        [TestMethod()]
        public void FindByLastNameTest()
        {
            var target = new AddressBook(new CAB.ConsoleLogger.ConsoleLogger());
            string lastName = string.Empty;
            var expected = new List<IContact>();
            List<IContact> actual = target.FindByLastName(lastName);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        /// <summary>
        /// simple test - return type should be boolean
        /// </summary>
        [TestMethod()]
        public void RemoveContactTest()
        {
            var target = new AddressBook(new CAB.ConsoleLogger.ConsoleLogger());
            bool expected = false;
            bool actual = target.RemoveContact(new Contact());
            Assert.AreEqual(expected, actual);            
        }

    }
}
