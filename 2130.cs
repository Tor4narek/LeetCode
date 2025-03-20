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
    public int PairSum(ListNode head) {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null) {
            slow = slow.next;       // Двигается на 1 шаг
            fast = fast.next.next;  // Двигается на 2 шага
        }
        ListNode prev = null;
        var curr = slow;
        while (curr != null)
        {
         var nextStep = curr.next;
         curr.next = prev;
         prev = curr;
         curr = nextStep;
        }

        var maxSum = 0;
        while (prev!=null)
        {
            maxSum = Math.Max(maxSum, head.val + prev.val);
            head = head.next;
            prev = prev.next;
        }

        return maxSum;
        
    }
}
