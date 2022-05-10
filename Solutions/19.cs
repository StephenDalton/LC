//
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode sentinalNode = new ListNode(0);
        sentinalNode.next = head;
        
        ListNode slow = sentinalNode;
        ListNode fast = sentinalNode;
        
        while (n > 0)
        {
            fast = fast.next;
            n--;
        }
        
        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return sentinalNode.next;
    }
}
