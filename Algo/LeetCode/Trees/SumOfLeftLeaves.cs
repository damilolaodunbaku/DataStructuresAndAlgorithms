using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.Trees
{
    /// <summary>
    /// 404. Sum of Left Leaves
    /// </summary>
    class SumOfLeftLeaves
    {
        int sum = 0;

        public int SumLeftLeaves(TreeNode root)
        {
            if (root == null) return sum;

            Recurse(root);

            return sum;
        }

        private void Recurse(TreeNode node)
        {
            if (node == null) return;

            if (node.left != null && node.left.left == null && node.left.right == null)
            {
                sum += node.left.val;
            }

            Recurse(node.left);
            Recurse(node.right);
        }
    }
}
