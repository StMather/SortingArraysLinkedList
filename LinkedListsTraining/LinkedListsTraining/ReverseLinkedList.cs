using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining.ReverseLinkedList
{
    public class Solution
    {
        /*public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            if (head.next == null)
            {
                return head;
            }
            ListNode newHead = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return newHead;


        }*/
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode cur = head;
            ListNode move;
            while (cur.next != null)
            {
                move = cur.next;//get next in line to move    
                cur.next = move.next;//points to next in line
                move.next = head;//sets head as moves next
                head = move;//set new head

            }
          return head;
        }
    }
}
