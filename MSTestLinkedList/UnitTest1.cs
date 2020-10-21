using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresDemo;

namespace MSTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        //Test case for Get Index
        [TestMethod]
        [DataRow(20)]
        [DataRow(40)]
        public void TestMethodGetIndex(int data)
        {
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            int expected = 2;
            int result = list.GetIndex(data);
            Assert.AreEqual(expected, result);
        }

        //Test case for Insert method
        [TestMethod]
        [DataRow(2,20)]
        [DataRow(4,50)]
        public void TestMethodInsertBetween(int position,int data)
        {
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(30);
            list.Add(40);
            int expected = 4;
            list.InsertAtParticularPositon(position, data);
            int result = list.GetIndex(data);
            Assert.AreEqual(expected, result);
        }
    }
}
