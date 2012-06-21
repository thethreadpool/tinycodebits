using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tinycodebits;

namespace tinycodebits.UnitTests
{
    [TestClass]
    public class MiscHelpersTests
    {
        [TestMethod]
        public void TestFibonicci()
        {
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
            int nth = MiscHelperMethods.FibinacciNumber(3);
            Assert.AreEqual(nth, 1);
            nth = MiscHelperMethods.FibinacciNumber(4);
            Assert.AreEqual(nth, 2);
            nth = MiscHelperMethods.FibinacciNumber(5);
            Assert.AreEqual(nth, 3);
            nth = MiscHelperMethods.FibinacciNumber(6);
            Assert.AreEqual(nth, 5);
            nth = MiscHelperMethods.FibinacciNumber(7);
            Assert.AreEqual(nth, 8);
            nth = MiscHelperMethods.FibinacciNumber(8);
            Assert.AreEqual(nth, 13);
        }

        [TestMethod]
        public void TestEquiIndex()
        {
            int[] A = { -7, 1, 5, 2, -4, 3, 0 };

            int equi = MiscHelperMethods.EquilibriumIndex(A);
            Assert.AreEqual(equi, 6);
        }
    }
}
