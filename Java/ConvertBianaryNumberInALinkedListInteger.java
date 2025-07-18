/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public int getDecimalValue(ListNode head) {
        int value = 0 ;
        for(ListNode curr = head; curr != null; curr = curr.next){
            value = (value << 1) | curr.val;

        }
        return value;
        
    }
}
