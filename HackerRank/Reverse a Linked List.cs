using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{

//https://www.hackerrank.com/challenges/reverse-a-linked-list/problem?h_r=next-challenge&h_v=zen
    class Reverse_a_Linked_List
    {
        static SinglyLinkedListNode reverse(SinglyLinkedListNode head)
        {

            if (head == null)
            {
                return head;
            }
            if (head.next == null)
            {
                return head;
            }
            SinglyLinkedListNode rev = reverse(head.next);
            head.next.next = head;
            head.next = null;
            return rev;


        }
    }
}
