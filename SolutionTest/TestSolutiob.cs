using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;
using System.Collections.Generic;

namespace SolutionTest
{
    [TestClass]
    public class TestPermutiation
    {
        [TestMethod]
        public void InitPermuteTest1()
        {
            Permutation.Solution s = new Permutation.Solution();
            var output = s.InitPermute(1, new int[] { 0, 2 });
            Assert.IsTrue( 1== 1);
        }     
    }

    [TestClass]
    public class TestAdd2Numbers
    {
        [TestMethod]
        public void InitPermuteTestTotal1()
        {
            Permutation.Solution s = new Permutation.Solution();
            IList<IList<int>> input = new List<IList<int>>();
            input.Add(new List<int>() { 1, 2, 3 });
            var output = s.Permute(input);
            Assert.IsTrue(1 == 1);
        }


        [TestMethod]
        public void TestGetNumber1()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(2);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(3);


            var output = s1.GetNUmber(l1);
            Assert.IsTrue(output == "342");

        }


        [TestMethod]
        public void TestGetIvalue1()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            l1.next = l2;
            l2.next = l3;


            ListNode l4 = new ListNode(1);
            ListNode l5 = new ListNode(2);
            ListNode l6 = new ListNode(3);
            l4.next = l5;
            l5.next = l6;


            var output = s1.AddTwoNumbers(l1, l4);
            Assert.IsTrue(1 == 1);
        }


        [TestMethod]
        public void TestAddTwoNumbers1()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(0);


            var output = s1.AddTwoNumbers(l1, l2);
            Assert.IsTrue(output == l1);
        }

        [TestMethod]
        public void TestGetLentgh1()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(1);
            // ListNode l2 = new ListNode(0);


            // var output = s1.GetLentgh(l1);
            // Assert.IsTrue(output == 1);
        }


        [TestMethod]
        public void TestGetNumber2()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(6);
            ListNode l3 = new ListNode(7);

            l2.next = l3;
            l1.next = l2;
            var output = s1.GetNUmber(l1);
            Assert.IsTrue(output == "765");

        }

        [TestMethod]
        public void TestGetListNode1()
        {
            Solution.Solution s1 = new Solution.Solution();
            // ListNode l1 = new ListNode();
            // ListNode l2 = new ListNode();
            //  ListNode l3 = new ListNode();


            var output = s1.numberToList(0);
            Assert.IsTrue(1 == 1);

        }

        [TestMethod]
        public void TestnumberToList()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(6);
            ListNode l3 = new ListNode(7);

            l2.next = l3;
            l1.next = l2;
            var output = s1.numberToList(765);
            Assert.IsTrue(output == l1); 
        }


        [TestMethod]
        public void TestnumberToList2()
        {
            Solution.Solution s1 = new Solution.Solution();
            //ListNode l = new ListNode(0);
            ListNode l1 = new ListNode(3);
            ListNode l2 = new ListNode(4);
            ListNode l3 = new ListNode(2);

            l2.next = l3;
            l1.next = l2;


            //ListNode l = new ListNode(0);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(6);
            ListNode l6 = new ListNode(5);


            l5.next = l6;
            l4.next = l5;


            var output = s1.AddTwoNumbers(l1, l4);
            Assert.IsTrue(output == l1); 
        }

        [TestMethod]
        public void TestAdd2Numbers1()
        {
            Solution.Solution s1 = new Solution.Solution();
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);

            ListNode l3 = new ListNode(6);
            ListNode l4 = new ListNode(4);

            l1.next = l2;



            var output = s1.AddTwoNumbers(l1, l2);
            Assert.IsTrue(1 == 1);
        }

    }














    //[2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9]
    // [5,6,4,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,2,4,3,9,9,9,9]



  
}
