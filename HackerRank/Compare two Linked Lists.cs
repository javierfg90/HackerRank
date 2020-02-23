using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Compare_two_Linked_Lists
    {
        //https://www.hackerrank.com/challenges/compare-two-linked-lists/problem
        static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null && head2 == null)
            {
                return true;
            }
            else if (head1 == null || head2 == null)
            {
                return false;
            }
            if (head1.data == head2.data)
            {
                return CompareLists(head1.next, head2.next);
            }
            else return false;


        }
    }
}
