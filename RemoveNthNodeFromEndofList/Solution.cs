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

    public class RemoveNthNodeFromEndofList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int i = 1;
            ListNode finalHead = null;

            if (n == 1)
                finalHead = head.next;

            while (i < n)
            {
                finalHead.next = head.next;
                head = head.next;
                i++;
            }

            if (head.next != null && head.next.next != null)
                finalHead.next = head.next.next;

            return finalHead;
        }
    }
}