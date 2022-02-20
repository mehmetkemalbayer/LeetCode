using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class MergeTwoSortedListProblem
    {
        
        public MergeTwoSortedListProblem()
        {
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode(0);
            ListNode current = result;
            bool run = true;
            if (list1 == null && list2 == null) return result.next;
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            do
            {
                if (list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    current = current.next;
                    list1 = list1.next;
                } else
                {
                    current.next = new ListNode(list2.val);
                    current = current.next;
                    list2 = list2.next;
                }
                if (list1 == null)
                {
                    current.next = list2;
                    run = false;
                }
                if (list2 == null)
                {
                    current.next = list1;
                    run = false;
                }

            } while (run);
            return result.next;
        }                
    }
    public class ListNode
    {
        public int val;
        public ListNode next;        
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
            
        }
        static public ListNode FromList(List<int> array)
        {
            ListNode node = new ListNode(0);
            ListNode current = node;
            array.ForEach(number => {

                current.next = new ListNode(number);
                current = current.next;
            });
            return node.next;
        }
        public List<int> ToList()
        {
            if (this == null) return new List<int>();
            List<int> list = new List<int>();
            ListNode current = this;
            do
            {
                list.Add(current.val);
                current = current.next;
            } while (current != null);
            return list;
        }

    }
}
