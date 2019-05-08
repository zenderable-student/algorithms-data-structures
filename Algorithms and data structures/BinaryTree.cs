using System;
namespace Algorithms_and_data_structures
{
    class TreeNode
    {
        public int data;
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public TreeNode(int data)
        {
            this.data = data;
        }
    }
    class Tree
    {
        public TreeNode
            root; //this is public so we can access this tree node from main when we display our tree using the recursive function
        public Tree()
        {
            root = null;
        }
        public void insert(int data)
        {
            TreeNode newItem = new TreeNode(data); //our new node to insert into the tree
            if (root == null) //if there is no root, make the first new node the root
            {
                root = newItem;
            }
            else
            {
                TreeNode
                    current = root; //we make a new tree node called current and assign to the root, so we start iteration from there

                TreeNode parent = null;
                while (current != null) //while the current is not equal to null (since we have it equal to root)
                {
                    parent = current; //set the parent node to point to current (which the root tree node, which will be the parent to the new item tree node)

                    if (data < current.data) //if new item (data) is less than the current node's data, link it to the left node
                    {
                        current = current.left;
                        if (current == null) //if the current.left is null
                        {
                            parent.left = newItem; //make parent.left store the new node
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newItem;
                        }
                    }
                }
            }
        }
        private void InOrderRecursiveTreeDisplay(TreeNode root)
        {
            if (root != null)
            {
                InOrderRecursiveTreeDisplay(root.left);
                Console.Write("({0})", root.data);
                InOrderRecursiveTreeDisplay(root.right);
            }
        }
        private bool RecursiveFindValue(TreeNode root, int data)
        {
            if (root != null)
            {
                RecursiveFindValue(root.left, data);
                RecursiveFindValue(root.right, data);
                if (root.data == data)
                {
                    Console.WriteLine("Value exists!");
                    return true;
                }
            }
            return false;
        }
        private TreeNode GoToTarget(int target) //method will return target node
        {
            TreeNode c = root;
            TreeNode returnThis = null;
            while (c != null)
            {
                if (target < c.data)
                {
                    c = c.left;
                }

                if (target == c.data)
                {
                    returnThis = c;
                    break;
                }

                if (target > c.data)
                {
                    c = c.right;
                }
            }
            return returnThis;
        }
        private TreeNode ParentOfTarget(TreeNode target)
        {
            //this method will return the parent node of the target node
            TreeNode current = root;
            TreeNode parent = null;
            while (current != null)
            {
                if (current.left == target || current.right == target)
                {
                    parent = current;
                    break;
                }
                if (target.data < current.data && current.left != target)
                {
                    current = current.left;
                }
                if (target.data > current.data && current.right != target)
                {
                    current = current.right;
                }
            }
            return parent;
        }
        private bool find(int target)
        {
            if (root != null && regular_find(target) != false)
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
            TreeNode current = root;
            while (current != null && isFound == false)
            {
                if (current.data == target)
                {
                    isFound = true;
                }
                if (target < current.data)
                {
                    if (current.left == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.left;
                    }
                }
                if (target > current.data)
                {
                    if (current.right == null)
                    {
                        break;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }
            if (isFound == true)
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
            if (root == null || find(target) == false) //before we can remove, check to see if it exists
            {
                Console.WriteLine("Value not found to delete!");
                return;
            }
            else
            {
                Console.WriteLine("{0} was removed from the tree",
                    Private_Remove(target)); //Private Remove method called here
                return;
            }
        }
        private int Private_Remove(int target) //private remove method does all work, returns the integer value removed
        {
            int temp;
            TreeNode targetNode = GoToTarget(target);
            //case 1, removing the root
            if (targetNode == root)
            {
                if (targetNode.left == null && targetNode.right == null)
                {
                    temp = root.data;
                    root = null;
                    return temp;
                }
                if (targetNode.left != null)
                {
                    //replace top with left if a left-right node dne, else go far right as possible
                    //delete left
                    TreeNode current = root.left;
                    temp = root.data;
                    if (root.left.right == null) //if theres no right child of the left child...
                    {
                        root.data = root.left.data;
                    }
                    else //if there is, we go left and then far right until...
                    {
                        while (current != null)
                        {
                            //we replace the root node with 2nd highest value
                            if (current.right.right == null)
                            {
                                root.data = current.right.data;
                                break;
                            }
                            current = current.right;
                        }
                        if (current.right != null)
                        {
                            current.right = current.right.right;
                        } //works
                        else
                        {
                            current.right = null;
                        }
                        return temp;
                    }
                    if (root.left.left == null)
                    {
                        root.left = null;
                    }
                    else
                    {
                        root.left = root.left.left;
                    }
                    return temp;
                }
                if (targetNode.right != null)
                {
                    temp = root.data;
                    root.data = root.right.data;
                    if (root.right.right == null)
                    {
                        root.right = null;
                    }
                    else
                    {
                        root.right = root.right.right;
                    }
                    return temp;
                }
            }
            //case 2 , removing nonroot
            if (targetNode.left == null && targetNode.right == null)
            {
                //target has no children
                if (ParentOfTarget(targetNode).left == targetNode)
                {
                    temp = targetNode.data;
                    ParentOfTarget(targetNode).left = null;
                }
                else
                {
                    temp = targetNode.data;
                    ParentOfTarget(targetNode).right = null;
                }
                return temp;
            }
            //target has 1 child
            if (targetNode.left != null && targetNode.right == null)
            {
                temp = targetNode.data;
                ParentOfTarget(targetNode).right = targetNode.left;
                //ParentOfTarget(targetNode).left = targetNode.left;//HERE
                return temp;
            }
            if (targetNode.right != null && targetNode.left == null)
            {
                temp = targetNode.data;
                //here if parent is the root, make it left = target->right
                if (ParentOfTarget(targetNode) == root)
                {
                    ParentOfTarget(targetNode).left = targetNode.right;
                }
                else
                    ParentOfTarget(targetNode).right = targetNode.right;
                return temp;
            }
            //target node has 2 children
            if (targetNode.left != null && targetNode.right != null)
            {
                if (ParentOfTarget(targetNode).left == targetNode)
                {
                    //take child.left and replace target
                    temp = targetNode.data;
                    targetNode.data = targetNode.left.data;
                    targetNode.left = null;
                    return temp;
                }
                else
                {
                    temp = targetNode.data;
                    targetNode.data = targetNode.left.data;
                    //check if left->left not null...
                    if (targetNode.left.left != null)
                    {
                        targetNode.left = targetNode.left.left;
                    }
                    else
                        targetNode.left = null;

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
                    binary.insert(value);
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
                    binary.InOrderRecursiveTreeDisplay(binary.root);
                    Console.WriteLine();
                    Console.ResetColor();
                }
                if (choice == 4) //find
                {
                    Console.Write("Enter value: ");
                    while (!int.TryParse(Console.ReadLine(), out value))
                        Console.Write("Type value: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    binary.RecursiveFindValue(binary.root, value);
                    Console.ResetColor();
                }
            } while (choice != 5); //exit, end of loop
        }
    }
}