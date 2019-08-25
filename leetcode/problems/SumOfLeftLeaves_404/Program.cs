
/*
https://leetcode.com/problems/sum-of-left-leaves/

Find the sum of all left leaves in a given binary tree.

Example:

   3
  / \
 9  20
   /  \
  15   7

There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24. 
*/

using System;
using System.Collections.Generic;
namespace SumOfLeftLeaves_404
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "[3,9,20,null,null,15,7]";
            var root = TreeCreator.Create(data);
            var sls = new Solution();
            var result = sls.SumOfLeftLeaves(root);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            var result = 0;
            var stack = new Stack<TreeNode>();
            while (stack.Count > 0 || root != null)
            {
                if (root != null)
                {
                    var tag = root != null && (root.left != null || root.right != null);
                    while (root != null)
                    {
                        stack.Push(root);
                        if (tag && root.left == null && root.right == null)
                            result += root.val;
                        root = root.left;
                    }
                }
                root = stack.Pop();
                root = root.right;
            }
            return result;
        }
    }
}
