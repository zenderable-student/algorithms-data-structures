using System;
namespace Algorithms_and_data_structures
{
    class TreeNode
    {
        public int Data;
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int data)
        {
            Data = data;
        }
    }
    class Tree
    {
        private TreeNode
            _root; //this is public so we can access this tree node from main when we display our tree using the recursive function
        private Tree()
        {
            _root = null;
        }
        private void Insert(int data)
        {
            TreeNode newItem = new TreeNode(data); //our new node to insert into the tree
            if (_root == null) //if there is no root, make the first new node the root
            {
                _root = newItem;
            }
            else
            {
                TreeNode
                    current = _root; //we make a new tree node called current and assign to the root, so we start iteration from there

                while (current != null) //while the current is not equal to null (since we have it equal to root)
                {
                    var parent = current;

                    if (data < current.Data) //if new item (data) is less than the current node's data, link it to the left node
                    {
                        current = current.Left;
                        if (current == null) //if the current.left is null
                        {
                            parent.Left = newItem; //make parent.left store the new node
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newItem;
                        }
                    }
                }
            }
        }
        private void InOrderRecursiveTreeDisplay(TreeNode root)
        {
            if (root != null)
            {
                InOrderRecursiveTreeDisplay(root.Left);
                Console.Write("({0})", root.Data);
                InOrderRecursiveTreeDisplay(root.Right);
            }
        }
        private void RecursiveFindValue(TreeNode root, int data)
        {
            if (root != null)
            {
                RecursiveFindValue(root.Left, data);
                RecursiveFindValue(root.Right, data);
                if (root.Data == data)
                {
                    Console.WriteLine("Value exists!");
                }
            }
        }
        private TreeNode GoToTarget(int target) //method will return target node
        {
            TreeNode c = _root;
            TreeNode returnThis = null;
            while (c != null)
            {
                if (target < c.Data)
                {
                    c = c.Left;
                }

                if (target == c.Data)
                {
                    returnThis = c;
                    break;
                }

                if (target > c.Data)
                {
                    c = c.Right;
                }
            }
            return returnThis;
        }
        private TreeNode ParentOfTarget(TreeNode target)
        {
            //this method will return the parent node of the target node
            TreeNode current = _root;
            TreeNode parent = null;
            while (current != null)
            {
                if (current.Left == target || current.Right == target)
                {
                    parent = current;
                    break;
                }
                if (target.Data < current.Data && current.Left != target)
                {
                    current = current.Left;
                }
                if (target.Data > current.Data && current.Right != target)
                {
                    current = current.Right;
                }
            }
            return parent;
        }
        private bool Find(int target)
        {
            if (_root != null && regular_find(target))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool regular_find(int target)
        {
            bool isFound = false;
            TreeNode current = _root;
            while (current != null && isFound == false)
            {
                if (current.Data == target)
                {
                    isFound = true;
                }
                if (target < current.Data)
                {
                    if (current.Left == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                if (target > current.Data)
                {
                    if (current.Right == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine("Found it!");
                return true;
            }
            else
            {
                Console.WriteLine("Not found");
                return false;
            }
        }
        private void Remove(int target)
        {
            if (_root == null || Find(target) == false) //before we can remove, check to see if it exists
            {
                Console.WriteLine("Value not found to delete!");
            }
            else
            {
                Console.WriteLine("{0} was removed from the tree",
                    Private_Remove(target)); //Private Remove method called here
            }
        }
        private int Private_Remove(int target) //private remove method does all work, returns the integer value removed
        {
            int temp;
            TreeNode targetNode = GoToTarget(target);
            //case 1, removing the root
            if (targetNode == _root)
            {
                if (targetNode.Left == null && targetNode.Right == null)
                {
                    temp = _root.Data;
                    _root = null;
                    return temp;
                }
                if (targetNode.Left != null)
                {
                    //replace top with left if a left-right node dne, else go far right as possible
                    //delete left
                    TreeNode current = _root.Left;
                    temp = _root.Data;
                    if (_root.Left.Right == null) //if theres no right child of the left child...
                    {
                        _root.Data = _root.Left.Data;
                    }
                    else //if there is, we go left and then far right until...
                    {
                        while (current != null)
                        {
                            //we replace the root node with 2nd highest value
                            if (current.Right.Right == null)
                            {
                                _root.Data = current.Right.Data;
                                break;
                            }
                            current = current.Right;
                        }
                        if (current != null && current.Right != null)
                        {
                            current.Right = current.Right.Right;
                        } //works
                        else
                        {
                            if (current != null) current.Right = null;
                        }
                        return temp;
                    }
                    if (_root.Left.Left == null)
                    {
                        _root.Left = null;
                    }
                    else
                    {
                        _root.Left = _root.Left.Left;
                    }
                    return temp;
                }
                if (targetNode.Right != null)
                {
                    temp = _root.Data;
                    _root.Data = _root.Right.Data;
                    if (_root.Right.Right == null)
                    {
                        _root.Right = null;
                    }
                    else
                    {
                        _root.Right = _root.Right.Right;
                    }
                    return temp;
                }
            }
            //case 2 , removing nonroot
            if (targetNode.Left == null && targetNode.Right == null)
            {
                //target has no children
                if (ParentOfTarget(targetNode).Left == targetNode)
                {
                    temp = targetNode.Data;
                    ParentOfTarget(targetNode).Left = null;
                }
                else
                {
                    temp = targetNode.Data;
                    ParentOfTarget(targetNode).Right = null;
                }
                return temp;
            }
            //target has 1 child
            if (targetNode.Left != null && targetNode.Right == null)
            {
                temp = targetNode.Data;
                ParentOfTarget(targetNode).Right = targetNode.Left;
                //ParentOfTarget(targetNode).left = targetNode.left;//HERE
                return temp;
            }
            if (targetNode.Right != null && targetNode.Left == null)
            {
                temp = targetNode.Data;
                //here if parent is the root, make it left = target->right
                if (ParentOfTarget(targetNode) == _root)
                {
                    ParentOfTarget(targetNode).Left = targetNode.Right;
                }
                else
                    ParentOfTarget(targetNode).Right = targetNode.Right;
                return temp;
            }
            //target node has 2 children
            if (targetNode.Left != null && targetNode.Right != null)
            {
                if (ParentOfTarget(targetNode).Left == targetNode)
                {
                    //take child.left and replace target
                    temp = targetNode.Data;
                    targetNode.Data = targetNode.Left.Data;
                    targetNode.Left = null;
                    return temp;
                }
                else
                {
                    temp = targetNode.Data;
                    targetNode.Data = targetNode.Left.Data;
                    //check if left->left not null...
                    if (targetNode.Left.Left != null)
                    {
                        targetNode.Left = targetNode.Left.Left;
                    }
                    else
                        targetNode.Left = null;

                    return temp;
                }
            }
            return Int32.MinValue;
        }
        public static void TreeMenu()
        {
            Tree binary = new Tree();
            int choice, value;
            do
            {
                Console.Write("\n1. INSERT\n2. REMOVE\n3. DISPLAY (InOrder)\n4. FIND\n5. EXIT TO MENU\nYour choice: "); //pick option
                while (!int.TryParse(Console.ReadLine(), out choice) || !(choice >= 1 && choice <= 5))
                    Console.Write("Type '1' to '5': "); //if wrong, type correct integer
                if (choice == 1) //adds an item into the binary tree
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    binary.Insert(value);
                    Console.ResetColor();
                }
                if (choice == 2) //remove
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    binary.Remove(value);
                    Console.ResetColor();
                }
                if (choice == 3) //display
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    binary.InOrderRecursiveTreeDisplay(binary._root);
                    Console.WriteLine();
                    Console.ResetColor();
                }
                if (choice == 4) //find
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    binary.RecursiveFindValue(binary._root, value);
                    Console.ResetColor();
                }
            } while (choice != 5); //exit, end of loop
        }
    }
}