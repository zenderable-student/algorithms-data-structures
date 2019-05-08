using System;
namespace Algorithms_and_data_structures
{
    internal class LinkedListClass
    {
        internal class Node //class definition
        {
            internal int data;
            internal Node Next;
            public Node(int d)
            {
                data = d;
                Next = null;
            }
        }
        internal class SingleLinkedList
        {
            internal Node Head;
        }
        private static void InsertFront(SingleLinkedList singlyList, int newData) //insert data at front of the Linked List 
        {
            Node newNode = new Node(newData);
            newNode.Next = singlyList.Head;
            singlyList.Head = newNode;
        }
        private static void InsertAfter(Node prevNode, int newData)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            Node newNode = new Node(newData);

            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }
        private static void InsertLast(SingleLinkedList singlyList, int newData)
        {
            Node newNode = new Node(newData);

            if (singlyList.Head == null)
            {
                singlyList.Head = newNode;
                return;
            }
            Node lastNode = GetLastNode(singlyList);

            lastNode.Next = newNode;
        }
        private static Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;

        }
        private static void DeleteNodebyPosition(SingleLinkedList singlyList, int position)
        {
            if (singlyList.Head == null)
            {
                return;
            }
            Node temp = singlyList.Head;

            if (position == 0)
            {
                singlyList.Head = temp.Next;
                return;
            }
            for (int i = 0; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }
            if (temp == null || temp.Next == null)
            {
                return;
            }
            // Node temp->next is the node to be deleted
            Node nextNode = temp.Next.Next;

            temp.Next = nextNode;
        }
        private static void DeleteNodeByKey(SingleLinkedList singlyList, int key)
        {
            Node temp = singlyList.Head;
            Node prev = null;
            if (temp != null && temp.data == key)
            {
                singlyList.Head = temp.Next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                return;
            }
            if (prev != null) prev.Next = temp.Next;
        }
        private static void SearchLinkedList(SingleLinkedList singlyList, int value)
        {
            Node temp = singlyList.Head;

            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("The Element {0} is present in Linked List", value);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("The Element {0} is NOT present in Linked List", value);
        }
        public static void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.Head;
            Node temp = null;

            while (current != null)
            {
                temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }
            singlyList.Head = prev;
        }
        /* Traverse linked list using two pointers.
         * Move one pointer by one and other pointer by two.
         * When the fast pointer reaches end slow pointer will reach middle of the linked list.
         * */
        private static void PrintList(SingleLinkedList singlyList)
        {
            Node n = singlyList.Head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.Next;
            }
        }
        public static void LinkedListMenu()
        {
            SingleLinkedList myLinkedList = new SingleLinkedList();
            int choice;
            do
            {
                Console.Write("\n1. INSERT AT FRONT\n2. INSERT AT MID\n3. INSERT AT END\n4. DELETE BY KEY\n5. DELETE BY POSITION\n6. DISPLAY\n7. FIND\n8. REVERSE\n9. EXIT TO MENU\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 9))
                    Console.Write("Type '1' to '9': "); //if wrong, type correct integer
                int value;
                if (choice == 1) //insert at frond
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    InsertFront(myLinkedList, value); //insert value at front
                    Console.ResetColor();
                }
                if (choice == 2) //insert after
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    InsertAfter(myLinkedList.Head.Next.Next, value); //insert value at front
                    Console.ResetColor();
                }
                if (choice == 3) //insert last
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    InsertLast(myLinkedList, value); //insert value at front
                    Console.ResetColor();
                }
                if (choice == 4) //delete by key
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    DeleteNodeByKey(myLinkedList, value); //insert value at front
                    Console.ResetColor();
                }
                if (choice == 5) //delete by position
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    DeleteNodebyPosition(myLinkedList, value); //insert value at front
                    Console.ResetColor();
                }
                if (choice == 6) //display
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintList(myLinkedList);
                    Console.ResetColor();
                }
                if (choice == 7) //find
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    SearchLinkedList(myLinkedList, value); //insert value at front
                    Console.ResetColor();
                }
                if (choice == 8) //display
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ReverseLinkedList(myLinkedList);
                    Console.ResetColor();
                }
            } while (choice != 9); //exit to menu
        }
    }
}
