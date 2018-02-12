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
            //res.Add(nums);
            while (n < mod)
            {
                int[] tmpN = null;// NewInt(nums);
                for (int i = 0; i < mod; i=i+1+n)
                {
                    tmpN = NewInt(nums);
                    if (n==mod-1)
                    {
                        var tmp = tmpN[0];
                        tmpN[0] = tmpN[1];
                        tmpN[1] = tmp;
                        res.Add(tmpN);
                    }
                    else
                    {
                        var tmp = tmpN[n];
                        tmpN[n] = tmpN[i];
                        tmpN[i] = tmp;
                        res.Add(tmpN);
                    }                                                                            
                }
                nums = NewInt(tmpN);
                n++;
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
