using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.LeetCode.Trees
{
    /*
    * 144. Binary Tree Preorder Traversal
    * Given the root of a binary tree, return the preorder traversal of its nodes' values.
    */
    public static class PreOrderTraversal
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
                
            List<int> elements = new List<int>();

            //PreOrderWithRecursion(root, elements);
            //PreOrderWithIteration(root, elements);

            return elements;
        }

        private static void PreOrderWithRecursion(TreeNode node, List<int> list)
        {
            if (node == null) return;

            PreOrderWithRecursion(node.left, list);
            list.Add(node.val);
            PreOrderWithRecursion(node.right, list);

        }

        private static void PreOrderWithIteration(TreeNode node, List<int> list)
        {
            Stack<TreeNode> treeNodes = new Stack<TreeNode>();
            treeNodes.Push(node);

            while (treeNodes.Count != 0)
            {
                node = treeNodes.Pop();
                list.Add(node.val);

                if (node.right != null)
                {
                    treeNodes.Push(node.right);
                }
                if(node.left != null)
                {
                    treeNodes.Push(node.left);
                }
            }
        }
    }
}
