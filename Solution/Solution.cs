using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Solution
    {

        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    var n1 = GetLentgh(l1);
        //    var n2 = GetLentgh(l2);
        //    var n = n1 > 2 ? n1 : n2;
        //    var res = new ListNode(0);
        //    var tmp = new ListNode(0);
        //    bool remain = false;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (remain)
        //        {
        //            tmp.val = GetIvalue(l1, i) + GetIvalue(l2, i);
        //        }
        //        else
        //        {
        //            tmp.val = GetIvalue(l1, i) + GetIvalue(l2, i) + 1;
        //        }
        //        if (tmp.val >= 10)
        //        {
        //            remain = true;
        //            tmp.val = tmp.val % 10;
        //        }
        //        else
        //        {
        //            remain = false;
        //        }
        //        res = tmp;
        //        tmp.next =
        //    }
        //    //return numberToList(int.Parse(n1) + int.Parse(n2));
        //    return res;
        //}

        //public int GetIvalue(ListNode l, int i)
        //{
        //    if (GetLentgh(l) >= i)
        //    {
        //        var res = 0;
        //        var tmp = l;
        //        for (int j = 0; j < i; j++)
        //        {
        //            tmp = tmp.next;
        //        }
        //        return tmp.val;
        //    }
        //    return -1;
        //}

        //public int GetLentgh(ListNode l)
        //{
        //    var tmp = l;
        //    var res = 0;
        //    while (tmp.next != null)
        //    {
        //        res++;
        //        tmp = tmp.next;
        //    }
        //    return res + 1;
        //}




        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var n1 = GetNUmber(l1);//.Reverse().ToString();
            var n2 = GetNUmber(l2);//.Reverse().ToString();
            return numberToList(double.Parse(n1) + double.Parse(n2));
        }



        public string GetNUmber(ListNode l1)
        {
            var temp = l1;
            var res = string.Empty;
            while (temp.next!=null)
            {
                var digit = temp.val.ToString();
                res = digit + res;
                temp = temp.next;
            }
            //add last entry 
            res = res +temp.val;
            return res;
        }

        public ListNode numberToList(double number)
        {
            if (number.ToString().Length==1)
            {
                return new ListNode(int.Parse(number.ToString()));
            }
            var num = number.ToString();//.Reverse();
            var l1 = new List<ListNode>();
            foreach (var s in num)
            {
                var l = new ListNode(int.Parse(s.ToString()));               
                l1.Add(l);
            }
            var res = new ListNode(l1[0].val);
            for (int i = 0;i < l1.Count-1;i++)
            {
                l1[i].next = l1[i+1];               
            }
            res.next = l1[l1.Count - 2];
            res.val = l1[0].val;

            return res;
        }

    }


    public class ListNode
    {
        public int val { get; set; }
        public ListNode next { get; set; }

        public ListNode(int v)
        {
            this.val = v;
        }
        public static bool IsTernary(ListNode l1)
        {
            return l1.next == null;
        }

        public void Connect(ListNode l1, ListNode l2)
        {
            l1.next = l2;
        }
    }
}
