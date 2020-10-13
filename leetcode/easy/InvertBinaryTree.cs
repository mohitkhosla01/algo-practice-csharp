using System;
using algo_practice_csharp.leetcode.definition;

namespace algo_practice_csharp.leetcode.easy
{
    public class InvertBinaryTree
    {
        private void Main(string[] args)
        {
            InvertBinaryTree invertBinaryTree = new InvertBinaryTree();

            /*
            TreeNode node = null;
            */

            /*
            TreeNode node = new TreeNode(7);
            */

            /*
            TreeNode node = new TreeNode(3);
            node.right = new TreeNode(2);
            */

            /*
            TreeNode node = new TreeNode(1);
            node.left = new TreeNode(5);
            node.right = new TreeNode(3);
            */

            TreeNode node = new TreeNode(4);
            node.left = new TreeNode(2);
            node.right = new TreeNode(7);
            node.left.left = new TreeNode(1);
            node.left.right = new TreeNode(3);
            node.right.left = new TreeNode(6);
            node.right.right = new TreeNode(9);

            /*
            TreeNode node = new TreeNode(3);
            node.left = new TreeNode(6);
            node.right = new TreeNode(8);
            node.left.left = new TreeNode(7);
            node.left.right = new TreeNode(6);
            node.right.right = new TreeNode(9);
            */

            /*
            TreeNode node = new TreeNode(4);
            node.left = new TreeNode(8);
            node.right = new TreeNode(7);
            node.left.left = new TreeNode(3);
            node.left.right = new TreeNode(2);
            */

            invertBinaryTree.Print(node);
            Console.WriteLine();

            node = invertBinaryTree.InvertTree(node);
            invertBinaryTree.Print(node);
            Console.WriteLine();
        }
        public void Print(TreeNode node)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    Print(node.left);
                }
                Console.Write(node.val);
                if (node.right != null)
                {
                    Print(node.right);
                }
            }
        }
        public TreeNode InvertTree(TreeNode root)
        {
            return SwapChildNodes(root);
        }
        public TreeNode SwapChildNodes(TreeNode node)
        {
            if(node == null)
            {
                return node;
            }

            if (node.left != null && node.right != null)
            {
                TreeNode temp = node.left;
                node.left = node.right;
                node.right = temp;
                SwapChildNodes(node.left);
                SwapChildNodes(node.right);
            }
            else if (node.left != null)
            {
                node.right = node.left;
                node.left = null;
                SwapChildNodes(node.right);
            }
            else if (node.right != null)
            {
                node.left = node.right;
                node.right = null;
                SwapChildNodes(node.left);
            }

            return node;
        }
    }
}
