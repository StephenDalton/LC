//https://leetcode.com/problems/rotate-list/discuss/923222/Java-0ms-faster-than-100-submissions-(With-explanation)
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
    public ListNode RotateRight(ListNode head, int k) {
        
        if(head == null || head.next == null)
            return head;
        
        ListNode dummy = head;
        int n = 1;
        
        while (dummy.next != null)
        {
            dummy = dummy.next;
            n++;
        }
        
        dummy.next = head;
        dummy = head;
        
        k = k % n;
        
        for (int i=0; i < n-k-1; i++)
        {
            dummy = dummy.next;
        }
        
        head = dummy.next;
        dummy.next = null;
        
        return head;
    }
}
