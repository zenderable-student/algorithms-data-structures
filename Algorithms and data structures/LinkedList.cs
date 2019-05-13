using System;
namespace Algorithms_and_data_structures
{
    internal class LinkedList
    {
        internal class Node //class definition
        {
            internal int data;
            internal Node Next;
            public Node(int d) //constructor to create a new node. Next is by default initialized as null
            {
                data = d;
                Next = null;
            }
        }
        private class SingleLinkedList
        {
            internal Node Head;
        }
        private static void InsertFront(SingleLinkedList singlyList, int newData) //insert data at front of the linked List 
        {
            Node newNode = new Node(newData); //create a new node. The next of the new node will point to the head of the linked list.
            newNode.Next = singlyList.Head;
            singlyList.Head = newNode; //the previous Head node is now the second node of linked list because the new node is added at the front. So, we will assign head to the new node.
        }
        private static void InsertLast(SingleLinkedList singlyList, int newData) //insert data at the end of the linked list
        {
            Node newNode = new Node(newData);

            if (singlyList.Head == null) //if the linked list is empty, then we simply add the new node as the Head of the linked list
            {
                singlyList.Head = newNode;
                return;
            }
            Node lastNode = GetLastNode(singlyList); //if the linked list is not empty, then we find the last node and make next of the last node to the new node, hence the new node is the last node now.
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
        private static void DeleteNodeByPosition(SingleLinkedList singlyList, int position) //given a position in Linked List, deletes the node at the given position
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
            //Node temp -> next is the node to be deleted
            Node nextNode = temp.Next.Next;

            temp.Next = nextNode;
        }
        private static void DeleteNodeByKey(SingleLinkedList singlyList, int key) //given a key, deletes the first occurrence of key in linked list
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
                    Console.WriteLine("The element {0} is present in linked list", value);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("The element {0} is NOT present in linked list", value);
        }
        private static void ReverseLinkedList(SingleLinkedList singlyList)
        {
            Node prev = null;
            Node current = singlyList.Head;

            while (current != null) //traverse linked list using two pointers
            {
                var temp = current.Next;
                current.Next = prev; 
                prev = current;
                current = temp;
            }
            singlyList.Head = prev; //when the fast pointer reaches end slow pointer will reach middle of the linked list
        }
        private static void PrintList(SingleLinkedList singlyList) //this function prints contents of linked list starting from head
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
                Console.Write("\n1. INSERT FRONT\n2. INSERT LAST\n3. DELETE BY KEY\n4. DELETE BY POSITION\n5. DISPLAY\n6. FIND\n7. REVERSE\n8. EXIT TO MENU\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 8))
                    Console.Write("Type '1' to '8': "); //if wrong, type correct integer
                int value;
                if (choice == 1) //insert at front
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    InsertFront(myLinkedList, value);
                    Console.ResetColor();
                }
                if (choice == 2) //insert last
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    InsertLast(myLinkedList, value);
                    Console.ResetColor();
                }
                if (choice == 3) //delete by key
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    DeleteNodeByKey(myLinkedList, value);
                    Console.ResetColor();
                }
                if (choice == 4) //delete by position
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    DeleteNodeByPosition(myLinkedList, value);
                    Console.ResetColor();
                }
                if (choice == 5) //display
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintList(myLinkedList);
                    Console.WriteLine();
                    Console.ResetColor();
                }
                if (choice == 6) //find
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    SearchLinkedList(myLinkedList, value);
                    Console.ResetColor();
                }
                if (choice == 7) //reverse
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ReverseLinkedList(myLinkedList);
                    Console.ResetColor();
                }
            } while (choice != 8); //exit to menu
        }
    }
}
