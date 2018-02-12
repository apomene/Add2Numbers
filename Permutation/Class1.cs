using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            int n = 0;
            int iterations = fact(nums.Length);
            IList<IList<int>> res = new List<IList<int>>();
            while (n < iterations)
            {
                for (int i = n; n < iterations; i++)
                {
                    var tmp = nums[i];
                    nums[i] = nums[n];
                    nums[n] = tmp;
                }
                res.Add(nums.ToList());
                n++;
            }
            return res;
        }


        public int fact(int n)
        {
            if (n == 0) return 1;
            else return n * fact(n - 1);
        }
    }
}
