using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Solution
    {
        myLinkedList l1 = new myLinkedList();
        myLinkedList l2 = new myLinkedList();

        public string GetNUmber(myLinkedList l1)
        {
            var temp = l1;
            var res = string.Empty;
            while (!myLinkedList.IsTernary(temp))
            {
                var digit = temp.value.ToString();
                res = digit + res;
                temp = temp.node;
            }
            //add last entry 
            res = temp.value + res;
            return res;
        }

        public void numberToList(int number)
        {

        }


    }


    public class myLinkedList
    {
        public int value { get; set; }
        public myLinkedList node { get; set; }

        public static bool IsTernary(myLinkedList l1)
        {
            return l1.node == null;
        }

        public void Connect(myLinkedList l1, myLinkedList l2)
        {
            l1.node = l2;
        }
    }
}
