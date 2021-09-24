using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public class MyLinkedList
    {
        public ListNode Head { get; set; }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Head = null;
        }

        /** Get the val of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (Head == null)
            {
                return -1;
            }
            int i = 0;
            ListNode toReturn = Head;
            while (i < index && toReturn.next != null)
            {
                toReturn = toReturn.next;
                i++;
            }
            if (i < index)//if over end  i < index
            {
                return -1;
            }
            return toReturn.val;
        }

        /** Add a node of val val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            ListNode mine = new ListNode(val);
            mine.next = Head;
            Head = mine;
        }

        /** Append a node of val val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (Head == null)
            {
                AddAtHead(val);
                return;
            }
            ListNode walker = Head;
            while (walker.next != null)
            {
                walker = walker.next;
            }
            ListNode toAdd = new ListNode(val);
            walker.next = toAdd;
        }

        /** Add a node of val val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index == 0)
            {
                AddAtHead(val);
                return;
            }
            if(Head == null)
            {
                return;
            }    
            ListNode cur = new ListNode(val);
            ListNode walkerFirst = Head;
            ListNode walkerBack = null;
            int i = 0;
            while (walkerFirst.next != null && i < index)
            {
                walkerBack = walkerFirst;
                walkerFirst = walkerFirst.next;
                i++;
            }
            if (i == index)// && walkerFirst.next != null)//middle
            {
                cur.next = walkerFirst;
                walkerBack.next = cur;
            }
            /*
            else if (walkerFirst.next == null && i == index)//end
            {
                cur.next = walkerFirst;
                walkerBack.next = cur;
            }*/
            else if (walkerFirst.next == null && i + 1 == index)//after
            {
                walkerFirst.next = cur;
            }

        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if(Head == null)
            {
                return;
            }
            if (index == 0)
            {
                Head = Head.next;
                return;
            }

            ListNode walkerFront = Head;
            ListNode walkerBack = null;
            int i = 0;
            while (walkerFront.next != null && i < index)
            {
                walkerBack = walkerFront;
                walkerFront = walkerFront.next;
                i++;
            }
            if (i == index && walkerFront.next != null)//in list
            {
                walkerBack.next = walkerFront.next;
            }
            else if (walkerFront.next == null && i == index)//end of list
            {
                walkerBack.next = null;

            }

        }
    }
}
