using System;
using algo_practice_csharp.leetcode.definition;

namespace algo_practice_csharp.leetcode.medium
{
    public class SortLinkedList
    {
        private void Main(string[] args)
        {
            SortLinkedList sortLinkedList = new SortLinkedList();

            /*
            ListNode node = null;
            */

            /*
            ListNode node = new ListNode(5);
            */

            /*
            ListNode node = new ListNode(5);
            node.next = new ListNode(2);
            */

            /*
            ListNode node = new ListNode(5);
            node.next = new ListNode(6);
            */

            ListNode node = new ListNode(4);
            node.next = new ListNode(2);
            node.next.next = new ListNode(1);
            node.next.next.next = new ListNode(3);

            /*
            ListNode node = new ListNode(3);
            node.next = new ListNode(5);
            node.next.next = new ListNode(6);
            node.next.next.next = new ListNode(8);
            node.next.next.next.next = new ListNode(4);
            */

            sortLinkedList.Print(node);
            node = sortLinkedList.SortList(node);
            sortLinkedList.Print(node);
        }

        public void Print(ListNode node)
        {
            while(node != null)
            {
                Console.Write(node.val);
                node = node.next;
            }
            Console.WriteLine();
        }

        public ListNode SortList(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }

            ListNode rightHead = GetRightHalf(head);
            ListNode left = SortList(head);
            ListNode right = SortList(rightHead);
            return MergeLists(left, right);
        }

        public ListNode GetRightHalf(ListNode node)
        {
            if(node == null)
            {
                return node;
            }

            ListNode mid = node;
            while(node.next != null && node.next.next != null)
            {
                mid = mid.next;
                node = node.next.next;
            }

            ListNode midNext = mid.next;
            mid.next = null;
            return midNext;
        }

        public ListNode MergeLists(ListNode left, ListNode right)
        {
            ListNode newList = new ListNode();
            ListNode newListHead = newList;

            while (left != null && right != null)
            {

                if (left.val < right.val)
                {
                    newList.next = left;
                    newList = newList.next;
                    left = left.next;
                }
                else
                {
                    newList.next = right;
                    newList = newList.next;
                    right = right.next;
                }
            }

            newList.next = (left != null) ? left : right;
            return newListHead.next;
        }
    }
}
