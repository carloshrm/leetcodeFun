using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    partial class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] productBucket = new int[nums.Length];
            int prodHolder = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                productBucket[i] = prodHolder;
                prodHolder *= nums[i];
            }

            prodHolder = 1;
            for (int i = (nums.Length - 1); i >= 0; i--)
            {
                productBucket[i] *= prodHolder;
                prodHolder *= nums[i];
            }
            
            return null;
        }
    }
}
/*

*/

//int[] ans = new int[nums.length];
//ans[0] = 1;

////prefix (left product) start with 1 because 0 index don't have prefix
//for (int i = 1; i < nums.length; i++)
//{
//    ans[i] = ans[i - 1] * nums[i - 1];
//}

////postfix (right product) keeping post as 1
//int post = 1;
//for (int i = nums.length - 1; i >= 0; i--)
//{
//    ans[i] = ans[i] * post;
//    post *= nums[i]; // update post product by current value 
//}

//return ans;