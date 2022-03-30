//https://leetcode.com/problems/reverse-nodes-in-k-group/discuss/183356/Java-O(n)-solution-with-super-detailed-explanation-and-illustration
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        ListNode pointer = dummy;
        
        while (pointer != null) 
        {
            ListNode node = pointer;
            
            // first check whether there are k nodes to reverse
            for (int i = 0; i < k && node != null; i++) 
            {
                node = node.next;
            }
            
            if (node == null) 
                break;
            
            // now we know that we have k nodes, we will start from the first node
            ListNode prev = null, curr = pointer.next, next = null;
            for (int i = 0; i < k; i++) 
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            
            ListNode tail = pointer.next;
            tail.next = curr;
            pointer.next = prev;
            pointer = tail;
        }
        
        return dummy.next;
    }
}
