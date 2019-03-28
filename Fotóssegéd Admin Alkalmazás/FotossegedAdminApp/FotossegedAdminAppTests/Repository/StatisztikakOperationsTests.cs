using Microsoft.VisualStudio.TestTools.UnitTesting;
using FotossegedAdminApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotossegedAdminApp.Repository.Tests
{
    [TestClass()]
    public class StatisztikakOperationsTests
    {
        [TestMethod()]
        public void getUserNumberTest()
        {
            StatisztikakOperations so = new StatisztikakOperations();
            string actual = so.getUserNumber("0");
            string expected = "5";
            Assert.AreEqual(expected, actual, "Felhasználók számára nem jó eredményt ad!");
        }
        
    }
}