using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    //www.hackerrank.com/challenges/merge-two-sorted-linked-lists/problem
    class Merge_Two_sorted_Linked_Lists
    {
        static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null && head2 == null)
            {
                return null;
            }
            if (head1 != null && head2 == null)
            {
                return head1;
            }
            if (head1 == null && head2 != null)
            {
                return head2;
            }
            if (head1.data <= head2.data)
            {
                head1.next = mergeLists(head1.next, head2);
                return head1;
            }
            else
            {
                head2.next = mergeLists(head1, head2.next);
                return head2;
            }

        }
}
