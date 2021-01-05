using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.Trees
{
    /*
    * 100. Same Tree
    * Given the roots of two binary trees p and q, write a function to check if they are the same or not.
    * Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
    */
    public static class SameTree
    {
        static bool theSame = true;
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            Traverse(p, q);
            return theSame;
        }

        private static void Traverse(TreeNode first, TreeNode second)
        {
            if (first == null && second == null)
            {
                return;
            }

            if (first != null && second == null)
            {
                theSame = false;
                return;
            }

            if (first == null && second != null)
            {
                theSame = false;
                return;
            }

            Traverse(first.left, second.left);

            if (first.val != second.val)
            {
                theSame = false;
            }

            Traverse(first.right, second.right);

        }
    }
}
