using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresDemo;

namespace MSTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
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
    }
}
