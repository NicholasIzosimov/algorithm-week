public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if(head != null) {
            ListNode prevNode = head;
            ListNode tempNode = head;
            ListNode currNode = head.next;
            
            prevNode.next = null;
            
            while(currNode != null) {
            tempNode = currNode.next;
            currNode.next = prevNode;
            prevNode = currNode;
            currNode = tempNode;
            }

            head = prevNode;
        }
        return head;
    }
    
    }

