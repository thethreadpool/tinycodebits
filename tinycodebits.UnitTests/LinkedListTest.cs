using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tinycodebits.UnitTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class LinkedListTest
    {
        public LinkedListTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCreateLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void TestLinkedListAddAndCount()
        {
            LinkedList list = GetPopulatedLinkedList("item", 3);
            Assert.AreEqual(list.Count, 3);
        }
        
        [TestMethod]
        public void TestAddAt()
        {
            LinkedList list = GetPopulatedLinkedList("item", 4);
            list.AddAt("newitem", 3);
            string value = (string)list.GetAt(3);
            Assert.AreEqual(value, "newitem");
        }

        [TestMethod]
        public void TestPop()
        {
            LinkedList list = GetPopulatedLinkedList("item", 5);
            string lastItem = (string) list.Pop();
            string secondToLastItem = (string)list.Pop();
            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(lastItem, "item5");
            Assert.AreEqual(secondToLastItem, "item4");
        }

        [TestMethod]
        public void ReverseListTest()
        {
            LinkedList list = GetPopulatedLinkedList("item", 5);
            list.Reverse();
            Assert.AreEqual(list.Count, 5);
            Assert.AreEqual((string)list.GetAt(0), "item5");
            Assert.AreEqual((string)list.GetAt(3), "item2");
        }

        [TestMethod]
        public void ConstrainedReverseListTest()
        {
            LinkedList list = GetPopulatedLinkedList("item", 5);
            list.ConstrainedReverse();
            Assert.AreEqual(list.Count, 5);
            Assert.AreEqual((string)list.GetAt(0), "item5");
            Assert.AreEqual((string)list.GetAt(3), "item2");
        }

        private LinkedList GetPopulatedLinkedList(string name, int count)
        {
            LinkedList list = new LinkedList();
            name = string.IsNullOrEmpty(name) ? "item" : name;
            for (int i = 0; i < count; i++)
            {
                list.Add(name + (i + 1).ToString());
            }
            return list;
        }
    }
}
