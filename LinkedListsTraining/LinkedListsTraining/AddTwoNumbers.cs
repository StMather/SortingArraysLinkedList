namespace LinkedListsTraining.AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode runner = null;
            int sumFirst = l1.val + l2.val + carry;
            if (sumFirst >= 10)
            {
                carry = 10;
            }
            else
            {
                carry = 0;
            }
            runner =  new ListNode(sumFirst - carry);//create addition function??? would have to return two things???
            ListNode headToReturn = runner;
            carry = carry / 10;
            
            while (l1.next != null && l2.next != null)//
            {
                l1 = l1.next;
                l2 = l2.next;
                int sum = l1.val + l2.val + carry;
                if(sum >= 10)
                {
                    carry = 10;
                }
                else
                {
                    carry = 0;
                }
                runner.next = new ListNode(sum - carry);
                carry = carry / 10;
                runner = runner.next;
            } 
            
            /*if (l1.next == null && l2.next == null)//once more with feeling
            {
                int sum = l1.val + l2.val + carry;
                if (sum >= 10)
                {
                    carry = 10;
                }
                else
                {
                    carry = 0;
                }
                runner.next = new ListNode(sum - carry);
                runner = runner.next;
                carry = carry / 10;
                return headToReturn;

            }*/
            while (l1.next != null || l2.next != null)
            {
                if (l1.next != null)//l1 not empty
                {
                    l1 = l1.next;
                    int sum = l1.val + carry;
                    if (sum >= 10)
                    {
                        carry = 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    runner.next = new ListNode(sum - carry);
                    runner = runner.next;
                    carry = carry / 10;
                }
                if (l2.next != null)//l2 not empty
                {
                    l2 = l2.next;
                    int sum = l2.val + carry;
                    if (sum >= 10)
                    {
                        carry = 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    runner.next = new ListNode(sum - carry );
                    runner = runner.next;
                    carry = carry / 10;
                }
            }
            if(carry >0)
            {
                runner.next = new ListNode(carry);
            }
            return headToReturn;
        }
       
    }
}
