using System;

namespace Algorithms_and_data_structures
{
    class Queue
    {
        private static int _front, _rear, _capacity;
        private static int[] _queue;
        private Queue(int c)
        {
            _front = _rear = 0;
            _capacity = c;
            _queue = new int[_capacity];
        }
        private void Enqueue(int data) //function to insert an element to the rear of the queue
        {
            if (_capacity == _rear) //check queue is full or not
            {
                Console.Write("\nQueue is full\n");
            }
            else //insert element at the rear  
            {
                _queue[_rear] = data;
                _rear++;
            }
        }
        private void Dequeue() //function to delete an element from the front of the queue 
        {
            if (_front == _rear) //if queue is empty
            {
                Console.Write("\nQueue is empty\n");
            }
            else //shift all the elements from index 2 till rear to the right by one
            {
                for (int i = 0; i < _rear - 1; i++)
                {
                    _queue[i] = _queue[i + 1];
                }
                if (_rear < _capacity) //store 0 at rear indicating there's no element 
                    _queue[_rear] = 0;
                _rear--; //decrement rear
            }
        }
        private void Display() //print queue elements  
        {
            int i;
            if (_front == _rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }
            for (i = _front; i < _rear; i++) //traverse front to rear and print elements
            {
                Console.Write(" {0} <-- ", _queue[i]);
            }
        }
        private void Peek()  //print front of queue
        {
            if (_front == _rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }
            Console.Write("\nFront element is: {0}", _queue[_front]);
        }
        public static void QueueMenu()
        {
            int size;
            Console.Write("Type size of queue: ");
            while (!int.TryParse(Console.ReadLine(), out size) || !(size > 0))
                Console.Write("Type size: ");
            Queue queue = new Queue(size);
            int choice;
            do
            {
                Console.Write("\n1. INSERT\n2. REMOVE\n3. PEEK\n4. DISPLAY\n5. EXIT TO MENU\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 5))
                    Console.Write("Type '1' to '5': "); //if wrong, type correct integer
                if (choice == 1) //adds an item into the queue
                {
                    Console.Write("Enter value: ");
                    int value;
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    queue.Enqueue(value);
                    Console.ResetColor();
                }
                if (choice == 2) //removes and returns an item from the beginning of the queue.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    queue.Dequeue();
                    Console.ResetColor();
                }
                if (choice == 3) //peek: returns an first item from the queue
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    queue.Peek();
                    Console.ResetColor();
                }
                if (choice == 4) //display
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    queue.Display();
                    Console.ResetColor();
                }
            } while (choice != 5); //exit, end of loop
        }
    }
}
