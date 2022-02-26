//https://leetcode.com/submissions/detail/583066653/
public class Solution {
    public bool HasCycle(ListNode head) {
        HashSet<ListNode> hash = new HashSet<ListNode>();
        while(head!=null) {
            if (!hash.Contains(head)) {
                hash.Add(head);
            } else {
                return true;
            }
            head = head.next;
        }
        return false;
    }
}
