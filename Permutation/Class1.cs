using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    public class Solution
    {
        public IList<IList<int>> Permute(IList<IList<int>> nums)
        {
             IList<IList<int>> res = new List<IList<int>>();
             var length = nums.Count;

            if ((length == 1 )&&(nums[0].Count == 1))
            {
                return nums;
            }
            else if (length == 1)  // nums[0].Count >1
            {
                var n = nums[0][0];
                nums[0].RemoveAt(0);
                return InitPermute(n, nums[0].ToArray());
            }
            else if (nums[0].Count > 1 ) //length > 1
            {
                return res;
            }
            return res;

           // return res;
        }

        public IList<IList<int>> InitPermute(int n,int[] num)
        {
            IList<IList<int>> res = new List<IList<int>>();
            //List<int> nums = num.ToList();
            for(int i=0; i<num.Length+1;i++)
            {
                List<int> nums = num.ToList();
                nums.Insert(i, n);
                res.Add(nums);
            }
            return res;
        }

        public int[] NewInt(int[] a)
        {
            var res = new int[a.Length];
            for (int i=0;i<a.Length;i++)
            {
                res[i] = a[i];
            }
            return res;
        }


        public void Swap(  int a,  int b,int[] nums)
        {
            var tmp = nums[a];
            nums[a] = nums[b];
            nums[b] = tmp;
        }



        public int fact(int n)
        {
            if (n == 0) return 1;
            else return n * fact(n - 1);
        }
    }
}
