using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static class RemoveNthFromEnd
    {
        public static ListNode Method(ListNode head, int n)
        {
            ListNode finalHead = head;

            if (n == 1 && head.next == null)
            {
                return new ListNode();
            }

            for (int i = 1; i < n; i++)
            {
                finalHead = finalHead.next;
            }

            if (head.next != null && head.next.next != null)
                finalHead.next = head.next.next;

            return finalHead;
        }
    }
}
