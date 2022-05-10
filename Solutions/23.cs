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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists == null || lists.Length == 0) 
            return null;
        
        List<ListNode> results = new List<ListNode>(lists.ToList());
        
        while (results.Count != 1)
        {
            ListNode l1 = results[0];
            ListNode l2 = results[1];
            results.RemoveAt(0);
            results.RemoveAt(0);

            results.Add(MergeLinkedLists(l1, l2));
        }
        
        return results[0];
    }
    
    
    
    private ListNode MergeLinkedLists(ListNode l1, ListNode l2) {
        ListNode sentinalNode = new ListNode(0);
        ListNode current = sentinalNode;
        
        while (l1 != null || l2 != null)
        {
            if (l2 == null || (l1 != null && l1.val < l2.val))
            {
                current.next = l1;
                current = l1;
                l1 = l1.next;
            }
            else
            {
                current.next = l2;
                current = l2;
                l2 = l2.next;
            }
        }
        
        return sentinalNode.next;
    }
}
