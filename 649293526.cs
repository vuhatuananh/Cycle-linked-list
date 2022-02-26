// https://leetcode.com/submissions/detail/649293526/

public class Solution {
    public bool HasCycle(ListNode head) {
        if(head==null) return false;
        ListNode slow = head, fast = head.next;
        while(fast!=null && fast.next!=null) {
            if(slow==fast) return true;
            slow = slow.next;
            fast = fast.next.next;
        }
        return false;
    }
}
