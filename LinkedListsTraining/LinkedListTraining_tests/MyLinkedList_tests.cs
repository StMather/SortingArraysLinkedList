using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 0;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetEmpty()
        {
            int expected = -1;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();
            actual = myLinkedList.Get(1);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetOutOfBOunds()
        {
            int expected = -1;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtHead(6);
            actual = myLinkedList.Get(4);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetEndOfList()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtHead(6);
            actual = myLinkedList.Get(3);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetMiddleOfList()
        {
            int expected = 2;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtHead(6);
            actual = myLinkedList.Get(2);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GetStartOfList()
        {
            int expected = 6;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(7);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtHead(6);
            actual = myLinkedList.Get(0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtTailEmpty()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtTail(7);
            actual = myLinkedList.Get(0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtTailFull()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtTail(7);
            actual = myLinkedList.Get(1);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtindexEmpty()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtIndex(0,7);
            actual = myLinkedList.Get(0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtindexEmptyOOB()
        {
            int expected = -1;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtIndex(1, 7);
            actual = myLinkedList.Get(1);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtindexEnd()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtIndex(1,7);
            actual = myLinkedList.Get(1);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtindexMiddle()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtIndex(1, 7);
            actual = myLinkedList.Get(1);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void AddAtindexStart()
        {
            int expected = 7;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtHead(4);
            myLinkedList.AddAtIndex(0, 7);
            actual = myLinkedList.Get(0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DeleteAtindexStart()
        {
            int expected = 2;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(3);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(0);
            actual = myLinkedList.Get(0);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DeleteAtindexMiddle()
        {
            int expected = 3;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(3);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(1);
            actual = myLinkedList.Get(1);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DeleteAtindexEnd()
        {
            int expected = -1;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddAtHead(3);
            myLinkedList.AddAtHead(2);
            myLinkedList.AddAtHead(1);
            myLinkedList.DeleteAtIndex(2);
            actual = myLinkedList.Get(2);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DeleteAtindexEmpty()
        {
            int expected = -1;
            int actual;
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.DeleteAtIndex(1);
            actual = myLinkedList.Get(0);

            Assert.AreEqual(expected, actual);

        }

    }
}
