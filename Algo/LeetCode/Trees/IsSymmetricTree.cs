using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.Trees
{
    /*
    * 101. Symmetric Tree
    * Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
    */
    public static class SymmetricTree
    {
        static bool IsSymmetricTree = true;
        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null)
            {
                return IsSymmetricTree;
            }
            CompareNodes(root.right, root.left);
            return IsSymmetricTree;
        }
        private static void CompareNodes(TreeNode right, TreeNode left)
        {
            if (right == null && left == null)
            {
                return;
            }
            if (right != null && left == null)
            {
                IsSymmetricTree = false;
                return;
            }
            if (right == null && left != null)
            {
                IsSymmetricTree = false;
                return;
            }
            if (right.val != left.val)
            {
                IsSymmetricTree = false;
            }
            CompareNodes(right.right, left.left);
            CompareNodes(right.left, left.right);
        }
    }
}
