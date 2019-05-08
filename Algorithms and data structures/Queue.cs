﻿using System;

namespace Algorithms_and_data_structures
{
    class QueueClass
    {
        public class Node //using linked list
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                this.Data = data;
            }
        }
        public class Queue
        {
            private Node _head;
            private Node _tail;
            private int _count = 0;
            public Queue() { }
            public void Enqueue(int data) //adds an item into the queue.
            {
                Node _newNode = new Node(data);
                if (_head == null)
                {
                    _head = _newNode;
                    _tail = _head;
                }
                else
                {
                    _tail.Next = _newNode;
                    _tail = _tail.Next;
                }
                _count++;
            }
            public int Dequeue() //removes nad returns an item from the beginning of the queue.
            {
                if (_head == null)
                {
                    throw new Exception("Queue is Empty");
                }
                _count--;
                int _result = _head.Data;
                _head = _head.Next;
                return _result;
            }
            public int Count //returns the total count of elements in the Queue.
            {
                get
                {
                    return this._count;
                }
            }
        }
    }
}
