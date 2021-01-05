using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.Trees
{
    /*
     * 94. Binary Tree Inorder Traversal
     * Given the root of a binary tree, return the inorder traversal of its nodes' values.
     */

    public static class InOrderTraversal
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            List<int> elements = new List<int>();

            //InOrderWithRecursion(root, elements);
            //InOrderWithIteration(root, elements);

            return elements;
        }

        private static void InOrderWithRecursion(TreeNode node, List<int> list)
        {
            if (node == null) return;

            InOrderWithRecursion(node.left, list);
            list.Add(node.val);
            InOrderWithRecursion(node.right, list);

        }

        private static void InOrderWithIteration(TreeNode node, List<int> list)
        {
            Stack<TreeNode> treeNodes = new Stack<TreeNode>();

            while(node != null || treeNodes.Count != 0)
            {
                while(node != null)
                {
                    treeNodes.Push(node);
                    node = node.left;
                }

                node = treeNodes.Pop();
                list.Add(node.val);
                node = node.right;
            }
        }
    }
}
