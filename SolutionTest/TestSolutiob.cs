using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;

namespace SolutionTest
{
    [TestClass]
    public class TestSolution
    {
        [TestMethod]
        public void TestGetNumber1()
        {
            Solution.Solution s1 = new Solution.Solution();
            myLinkedList l1 = new myLinkedList();
            myLinkedList l2 = new myLinkedList();
            myLinkedList l3 = new myLinkedList();
            l1.value = 2;
            l1.node = l2;
            l2.value = 4;
            l2.node = l3;
            l3.value = 3;
            var output = s1.GetNUmber(l1);
            Assert.IsTrue(output == "342");

        }


        [TestMethod]
        public void TestGetNumber2()
        {
            Solution.Solution s1 = new Solution.Solution();
            myLinkedList l1 = new myLinkedList();
            myLinkedList l2 = new myLinkedList();
            myLinkedList l3 = new myLinkedList();
            l1.value = 5;
            l1.node = l2;
            l2.value = 6;
            l2.node = l3;
            l3.value = 7;
            var output = s1.GetNUmber(l1);
            Assert.IsTrue(output == "765");

        }
    }
}
