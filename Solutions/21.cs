//https://leetcode.com/problems/merge-two-sorted-lists/discuss/9858/Java-solution-for-reference/10766
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode sentinalNode = new ListNode(0);
        ListNode current = sentinalNode;
        
        while (list1 != null || list2 != null)
        {
            if (list2 == null || (list1 != null && list1.val <= list2.val))
            {
                current.next = list1;
                current = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                current = list2;
                list2 = list2.next;
            }
        }
        
        return sentinalNode.next;
    }
}
