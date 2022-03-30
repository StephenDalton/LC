//https://leetcode.com/problems/reverse-linked-list-ii/discuss/30667/Easy-understanding-java-solution
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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        
        //first part
        ListNode cur1 = dummy;
        ListNode prev1 = null;
        
        for (int i=0; i<left; i++)
        {
            prev1 = cur1;
            cur1 = cur1.next;
        }
        
        //reverse
        ListNode cur2 = cur1;
        ListNode prev2 = prev1;
        
        for (int i=left; i<=right; i++)
        {
            ListNode temp = cur2.next;
            cur2.next = prev2;
            prev2 = cur2;
            cur2 = temp;
        }
        
        //connect 
        prev1.next = prev2;
        cur1.next = cur2;
        
        return dummy.next;
    }
}
