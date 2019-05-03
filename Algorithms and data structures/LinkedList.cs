using System;
namespace Algorithms_and_data_structures
{
    class LinkedListClass
    {
        internal class Node //class definition
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        internal class SingleLinkedList
        {
            internal Node head;
        }
        internal void InsertFront(SingleLinkedList singlyList, int new_data) //insert data at front of the Linked List 
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
        internal void DeleteNodebyKey(SingleLinkedList singlyList, int key)
        {
            Node temp = singlyList.head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }
        public void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            singlyList.head = prev;
        }
    }
}
