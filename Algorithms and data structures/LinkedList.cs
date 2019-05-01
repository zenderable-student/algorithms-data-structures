namespace Algorithms_and_data_structures
{
    internal class Node
    {
        internal int Data;
        internal Node Next;
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
    internal class LinkedList
    {
        internal Node head;
        internal void InsertFront(LinkedList singlyList, int newData)
        {
            Node new_node = new Node(newData);
            new_node.Next = singlyList.head;
            singlyList.head = new_node;
        }
        internal void InsertLast(LinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.Next = new_node;
        }
        internal Node GetLastNode(LinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }
    }
}
