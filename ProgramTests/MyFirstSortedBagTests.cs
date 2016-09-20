using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tests
{
    [TestClass()]
    public class MyFirstSortedBagTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ISortedBag s = new MyFirstSortedBag();

            s.Add(5);
            Assert.AreEqual(5, s.Get()[0]);
        }
    }
}