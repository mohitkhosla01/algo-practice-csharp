using algo_practice_csharp.leetcode.definition;
using System;

namespace algo_practice_csharp.leetcode.medium
{
    public class CountGoodNodesInBinaryTree
    {
        int goodNodeCount = 0;

        private void Main(string[] args)
        {
            CountGoodNodesInBinaryTree obj = new CountGoodNodesInBinaryTree();

            TreeNode node1 = new TreeNode(3);
            node1.left = new TreeNode(1);
            node1.left.left = new TreeNode(3);
            node1.right = new TreeNode(4);
            node1.right.left = new TreeNode(1);
            node1.right.right = new TreeNode(5);
            Console.WriteLine(obj.GoodNodes(node1));

            TreeNode node2 = new TreeNode(3);
            node2.left = new TreeNode(3);
            node2.left.left = new TreeNode(4);
            node2.left.right = new TreeNode(2);
            Console.WriteLine(obj.GoodNodes(node2));

            TreeNode node3 = new TreeNode(9);
            node3.right = new TreeNode(3);
            node3.right.left = new TreeNode(6);
            Console.WriteLine(obj.GoodNodes(node3));

            TreeNode node11 = new TreeNode(5);
            node11.left = new TreeNode(8);
            node11.left.left = new TreeNode(4);
            node11.left.right = new TreeNode(9);
            node11.right = new TreeNode(2);
            node11.right.left = new TreeNode(3);
            node11.right.right = new TreeNode(5);
            Console.WriteLine(obj.GoodNodes(node11));

            TreeNode node12 = new TreeNode(1);
            Console.WriteLine(obj.GoodNodes(node12));

            TreeNode node13 = null;
            Console.WriteLine(obj.GoodNodes(node13));
        }

        public int GoodNodes(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            goodNodeCount = 0;
            IsGoodNode(root, root.val);
            return goodNodeCount;
        }

        public void IsGoodNode(TreeNode node, int highestVal)
        {
            if (node != null)
            {
                if (node.val >= highestVal)
                {
                    ++goodNodeCount;
                }

                IsGoodNode(node.left, node.val > highestVal ? node.val : highestVal);
                IsGoodNode(node.right, node.val > highestVal ? node.val : highestVal);
            }
        }
    }
}
