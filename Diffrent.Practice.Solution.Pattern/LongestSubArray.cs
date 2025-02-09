using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class LongestSubArray
    {
        public static int FindLongestSub(int[] arr)
        {
            int logestSubArray = 0;
            HashSet<int> result = new HashSet<int>(arr);
            foreach (var i in arr)
            {
                if (!result.Contains(i - 1))
                {
                    int current = i;
                    int curentItem = 1;
                    while (result.Contains(current + 1))
                    {
                        current++;
                        curentItem++;
                    }
                    logestSubArray = Math.Max(logestSubArray, curentItem);
                }
            }
            return logestSubArray;
        }


    }
}
