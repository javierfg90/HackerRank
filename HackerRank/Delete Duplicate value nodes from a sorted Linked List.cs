using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Delete_Duplicate_value_nodes_from_a_sorted_Linked_List
    {
        //https://www.hackerrank.com/challenges/delete-duplicate-value-nodes-from-a-sorted-linked-list/problem
        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head)
        {
            if (head == null)
            {
                return null;
            }
            SinglyLinkedListNode aux = head.next;
            while (aux != null && aux.data == head.data)
            {
                aux = aux.next;
            }
            head.next = removeDuplicates(aux);
            return head;


        }
    }
}
