using System;
using algo_practice_csharp.leetcode.definition;

namespace algo_practice_csharp.leetcode.medium
{
    public class AddTwoNumbersProblem
    {
        private void Main(String[] args)
        {
            AddTwoNumbersProblem obj = new AddTwoNumbersProblem();

            ListNode node1 = new ListNode(2);
            node1.next = new ListNode(4);
            node1.next.next = new ListNode(3);
            ListNode node2 = new ListNode(5);
            node2.next = new ListNode(6);
            node2.next.next = new ListNode(4);

            //ListNode node1 = new ListNode(0);
            //ListNode node2 = new ListNode(0);

            //ListNode node1 = new ListNode(9);
            //node1.next = new ListNode(9);
            //node1.next.next = new ListNode(9);
            //node1.next.next.next = new ListNode(9);
            //node1.next.next.next.next = new ListNode(9);
            //node1.next.next.next.next.next = new ListNode(9);
            //node1.next.next.next.next.next.next = new ListNode(9);
            //ListNode node2 = new ListNode(9);
            //node2.next = new ListNode(9);
            //node2.next.next = new ListNode(9);
            //node2.next.next.next = new ListNode(9);

            ListNode sumNode = AddTwoNumbers(node1, node2);
            while(sumNode != null)
            {
                Console.WriteLine(sumNode.val);
                sumNode = sumNode.next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode sumNode = new ListNode(0);
            ListNode startPointer = sumNode;
            int carry = 0;

            while(l1 != null || l2 != null)
            {
                if(l1 == null)
                {
                    sumNode.next = new ListNode((l2.val + carry) % 10);
                    carry = (l2.val + carry) / 10;
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    sumNode.next = new ListNode((l1.val + carry) % 10);
                    carry = (l1.val + carry) / 10;
                    l1 = l1.next;
                }
                else
                {
                    sumNode.next = new ListNode((l1.val + l2.val + carry) % 10);
                    carry = (l1.val + l2.val + carry) / 10;
                    l1 = l1.next;
                    l2 = l2.next;
                }

                sumNode = sumNode.next;
            }

            if(carry == 1)
            {
                sumNode.next = new ListNode(1);
            }

            return startPointer.next;
        }
    }
}
