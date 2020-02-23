using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    //https://www.hackerrank.com/challenges/get-the-value-of-the-node-at-a-specific-position-from-the-tail/problem
    //Time Complexity=O(n)
    class Get_the_value_of_the_node_at_a_specific_position_from_the_tail
    {
        static int getNode(SinglyLinkedListNode head, int positionFromTail)
        {
            int index = 0;
            SinglyLinkedListNode temp = head;
            SinglyLinkedListNode result = head;
            while (temp != null)
            {
                temp = temp.next;
                if (index > positionFromTail)
                {
                    result = result.next;
                }
                index++;
            }
            return result.data;




        }
    }
}
