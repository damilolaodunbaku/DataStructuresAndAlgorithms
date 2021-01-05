using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.Trees
{
    public static class PostOrderTraversal
    {
        public static IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            List<int> elements = new List<int>();

            //PostOrderWithRecursion(root, elements);
            //PostOrderWithIteration(root, elements);

            return elements;
        }

        private static void PostOrderWithRecursion(TreeNode node, List<int> list)
        {
            if (node == null) return;

            PostOrderWithRecursion(node.left, list);
            PostOrderWithRecursion(node.right, list);
            list.Add(node.val);

        }

        //private static void PostOrderWithIteration(TreeNode node, List<int> list)
        //{
            
        //}
    }
}
