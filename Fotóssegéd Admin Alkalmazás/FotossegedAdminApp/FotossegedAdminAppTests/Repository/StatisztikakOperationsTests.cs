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
            string actual = so.getUserNumber("0"); //Az adatbázisból lekért felhasználók száma
            string expected = "5"; //A valós eredmény, amit elvárunk
            Assert.AreEqual(expected, actual, "Felhasználók számára nem jó eredményt ad!");
        }

        [TestMethod()]
        public void getKepekNumber()
        {
            StatisztikakOperations so = new StatisztikakOperations();
            string actual = so.getKepekNumber("0"); //Az adatbázisból lekért fényképek száma
            string expected = "9"; //A valós eredmény, amit elvárunk
            Assert.AreEqual(expected, actual, "Fényképek számára nem jó eredményt ad!");
        }

    }
}