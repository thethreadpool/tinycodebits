using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tinycodebits.UnitTests
{
    [TestClass]
    public class CircleIntersectsionTest
    {
        /// <summary>
        /// tests that the circle.Intersects method properly determines whether 2
        /// circles Intersects
        /// </summary>
        public void TestCirclesIntersects()
        {
            //create a few circles
            Circle circle1 = new Circle { Center = new Point(0,0), Radius = 2};
            Circle circle2 = new Circle { Center = new Point(0,0), Radius = 3};
            Circle circle3 = new Circle { Center = new Point(6, 0), Radius = 3 };
            Circle circle4 = new Circle { Center = new Point(1, 1), Radius = 3 };

            //non-Intersectsing circles
            Assert.IsFalse(circle1.Intersects(circle3));
            Assert.IsFalse(circle3.Intersects(circle1));
            Assert.IsFalse(circle1.Intersects(null));

            //touching circles
            Assert.IsTrue(circle2.Intersects(circle3));
            Assert.IsTrue(circle3.Intersects(circle2));

            //Intersectsing circles
            Assert.IsTrue(circle1.Intersects(circle2));
            Assert.IsTrue(circle2.Intersects(circle1));
            Assert.IsTrue(circle2.Intersects(circle4));
            Assert.IsTrue(circle4.Intersects(circle2));
            Assert.IsTrue(circle1.Intersects(circle4));
            Assert.IsTrue(circle4.Intersects(circle1));
            Assert.IsTrue(circle3.Intersects(circle4));
            Assert.IsTrue(circle4.Intersects(circle3));
        }


    }
}
