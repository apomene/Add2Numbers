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
            int mod = nums.Length;
            int iterations = fact(mod);
            IList<IList<int>> res = new List<IList<int>>();
            while (n < iterations)
            {
                for (int i = n; i < n%nums.Length; i++)
                {
                    var tmp = nums[i];
                    nums[i] = nums[( i+ n) % mod];
                    nums[( i+n) % mod] = tmp;
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
