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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        
        while(fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        ListNode secondHalf = ReverseList(slow);
        ListNode firstHalf = head;
        
        head = MergeLists(head, secondHalf);
    }
    
    private ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        
        while (head != null)
        {
            ListNode temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        
        return prev;
    }
    
    private ListNode MergeLists(ListNode l1, ListNode l2) {
        ListNode sentinelNode = new ListNode(0);
        sentinelNode.next = l1;
        
        while (l1 != null)
        {
            ListNode temp = l1.next;
            l1.next = l2;
            l1 = l2;
            l2 = temp;
        }
        
        return sentinelNode.next;
    }
}
