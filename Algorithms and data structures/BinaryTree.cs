﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms_and_data_structures
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }
        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
            switch (mode)
            {
                case TraversalEnum.Preorder:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.Inorder:
                    TraverseInOrder(Root, nodes);
                    break;
                case TraversalEnum.Postorder:
                    TraversePostOrder(Root, nodes);
                    break;
            }
            return nodes;
        }
        private void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);
            }
        }
        private void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left, result);
                result.Add(node);
                TraverseInOrder(node.Right, result);
            }
        }
        private void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);
                result.Add(node);
            }
        }
        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalEnum.Preorder))
            {
                height = Math.Max(height, node.GetHeight());
            }
            return height;
        }
    }
    public class BinaryTreeMenu
    {
        private const int ColumnWidth = 5;
        public static void TreeMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            int choice, data;
            //int choiceRoot, choiceRootLeft, choiceRootRight;
            //Console.Write("\nThis is a binary tree data structure. Type root value (the best will be > 100): ");
            //while (!int.TryParse(Console.ReadLine(), out choiceRoot))
            //    Console.Write("Type value: ");
            //tree.Root = new BinaryTreeNode<int>() { Data = choiceRoot };
            //Console.Write("Type left value: ");
            //while (!int.TryParse(Console.ReadLine(), out choiceRootLeft))
            //    Console.Write("Type value: "); ;
            //tree.Root.Left = new BinaryTreeNode<int>() { Data = choiceRootLeft, Parent = tree.Root };
            //Console.Write("Type right value: ");
            //while (!int.TryParse(Console.ReadLine(), out choiceRootRight))
            //    Console.Write("Type value: "); ;
            //tree.Root.Right = new BinaryTreeNode<int>() { Data = choiceRootRight, Parent = tree.Root };
            tree.Count = 0;
            do
            {
                Console.Write("\n1. ADD\n2. REMOVE\n3. FILL WITH RANDOM NUMBERS\n4. TRAVERSE\n5. DISPLAY\n6. EXIT TO MENU\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 6))
                    Console.Write("Type '1' to '5': "); //if wrong, type correct integer
                if (choice == 1) //adds an item into the binary tree
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out data))
                        Console.Write("Type value: ");
                    tree.Add(data);
                }
                if (choice == 2) //remove
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out data))
                        Console.Write("Type value: ");
                    tree.Remove(data);
                }
                if (choice == 3) //fill with random numbers
                {
                    int howMany;
                    Console.Write("Enter how many numbers fill randomly: ");
                    while (!int.TryParse(Console.ReadLine(), out howMany))
                        Console.Write("Type value: ");
                    Random random = new Random();
                    for (int i = 0; i < howMany; i++)
                    {
                        int number;
                        do
                        {
                            number = random.Next(100);
                        } while (tree.Contains(number));
                        tree.Add(number);
                    }
                }
                if (choice == 4) //traverse
                {
                    int traverseChoice;
                    Console.Write("\n1. PreOrder\n2. InOrder\n3. PostOrder\nYour choice: ");
                    while (!int.TryParse(Console.ReadLine(), out traverseChoice))
                        Console.Write("Type value: ");
                    if (traverseChoice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(string.Join(", ", tree.Traverse(TraversalEnum.Preorder).Select(n => n.Data)));
                        Console.ResetColor();
                    }
                    if (traverseChoice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(string.Join(", ", tree.Traverse(TraversalEnum.Inorder).Select(n => n.Data)));
                        Console.ResetColor();
                    }
                    if (traverseChoice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(string.Join(", ", tree.Traverse(TraversalEnum.Postorder).Select(n => n.Data)));
                        Console.ResetColor();
                    }
                }
                if (choice == 5) //display
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    VisualizeTree(tree, " -----> ");
                    Console.ResetColor();
                }
            } while (choice != 6); //exit, end of loop
        }
        private static void VisualizeTree(BinarySearchTree<int> tree, string caption)
        {
            Console.WriteLine(tree.Count);
            char[][] console = InitializeVisualization(tree, out int width);
            VisualizeNode(tree.Root, 0, width / 2, console, width);
            Console.WriteLine(caption);
            foreach (char[] row in console)
            {
                Console.WriteLine(row);
            }
        }

        private static char[][] InitializeVisualization(BinarySearchTree<int> tree, out int width)
        {
            int height = tree.GetHeight();
            width = (int)Math.Pow(2, height) - 1;
            char[][] console = new char[height * 2][];
            for (int i = 0; i < height * 2; i++)
            {
                console[i] = new char[ColumnWidth * width];
            }
            return console;
        }
        private static void VisualizeNode(BinaryTreeNode<int> node, int row, int column, char[][] console, int width)
        {
            if (node != null)
            {
                char[] chars = node.Data.ToString().ToCharArray();
                int margin = (ColumnWidth - chars.Length) / 2;
                for (int i = 0; i < chars.Length; i++)
                {
                    console[row][ColumnWidth * column + i + margin] = chars[i];
                }

                int columnDelta = (width + 1) / (int)Math.Pow(2, node.GetHeight() + 1);
                VisualizeNode(node.Left, row + 2, column - columnDelta, console, width);
                VisualizeNode(node.Right, row + 2, column + columnDelta, console, width);
                DrawLineLeft(node, row, column, console, columnDelta);
                DrawLineRight(node, row, column, console, columnDelta);
            }
        }

        private static void DrawLineRight(BinaryTreeNode<int> node, int row, int column, char[][] console, int columnDelta)
        {
            if (node.Right != null)
            {
                int startColumnIndex = ColumnWidth * column + 2;
                int endColumnIndex = ColumnWidth * (column + columnDelta) + 2;
                for (int x = startColumnIndex + 1; x < endColumnIndex; x++)
                {
                    console[row + 1][x] = '-';
                }
                console[row + 1][startColumnIndex] = '+';
                console[row + 1][endColumnIndex] = '\u2510';
            }
        }
        private static void DrawLineLeft(BinaryTreeNode<int> node, int row, int column, char[][] console, int columnDelta)
        {
            if (node.Left != null)
            {
                int startColumnIndex = ColumnWidth * (column - columnDelta) + 2;
                int endColumnIndex = ColumnWidth * column + 2;
                for (int x = startColumnIndex + 1; x < endColumnIndex; x++)
                {
                    console[row + 1][x] = '-';
                }
                console[row + 1][startColumnIndex] = '\u250c';
                console[row + 1][endColumnIndex] = '+';
            }
        }
    }
}