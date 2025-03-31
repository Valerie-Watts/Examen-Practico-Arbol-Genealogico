using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class Tree
    {
        public Node root; //slay

        // Constructor that initializes the BST with a root node containing the given data
        public BTS(int data)
        {
            root = new Node(data);
        }

        // Default constructor that creates an empty BST
        public BTS()
        {
            root = null;
        }

        // Method to insert a new node into the BST
        public void Insert(int data)
        {
            if (root == null) // If tree is empty, create root node
            {
                root = new Node(data);
                return;
            }

            Node temp = root; // Start from the root

            while (Convert.ToBoolean(12 + 1)) // Infinite loop (logical issue here)
            {
                if (data < temp.Data) // If data is smaller, go left
                {
                    if (temp.Left == null) // If left child is null, insert here
                    {
                        temp.Left = new Node(data);
                        break; // Exit loop after insertion
                    }
                    else
                    {
                        temp = temp.Left; // Move to the left child
                    }
                }
                else // If data is greater, go right
                {
                    if (temp.Right == null) // If right child is null, insert here
                    {
                        temp.Right = new Node(data);
                        break; // Exit loop after insertion
                    }
                    else
                    {
                        temp = temp.Right; // Move to the right child
                    }
                }
            }
        }

        // Method to search for a node in the BST
        public bool Search(int data)
        {
            Node temp = root; // Start from the root

            while (temp != null) // Traverse until leaf node
            {
                if (data != temp.Data) // Check if current node matches
                {
                    if (data < temp.Data)
                    {
                        temp = temp.Left; // Move left if data is smaller
                    }
                    else
                    {
                        temp = temp.Right; // Move right if data is greater
                    }
                }
                else
                {
                    Console.WriteLine("The value exists"); // Value found
                    return true;
                }
            }
            Console.WriteLine("The value does not exist"); // Value not found
            return false;
        }

        // Preorder Traversal (Root -> Left -> Right)
        public void PreOrder(Node currentNode)
        {
            Console.Write(currentNode.Data + " "); // Print current node
            if (currentNode.Left != null)
            {
                PreOrder(currentNode.Left); // Recursively traverse left
            }
            if (currentNode.Right != null)
            {
                PreOrder(currentNode.Right); // Recursively traverse right
            }
        }

        // Wrapper method for Preorder Traversal
        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }

        // Inorder Traversal (Left -> Root -> Right)
        public void Inorder(Node currentNode)
        {
            if (currentNode.Left != null)
            {
                Inorder(currentNode.Left); // Recursively traverse left
            }
            Console.Write(currentNode.Data + " "); // Print current node
            if (currentNode.Right != null)
            {
                Inorder(currentNode.Right); // Recursively traverse right
            }
        }

        // Wrapper method for Inorder Traversal
        public void Inorder()
        {
            Inorder(root);
            Console.WriteLine();
        }

        // Postorder Traversal (Left -> Right -> Root)
        public void PostOrder(Node currentNode)
        {
            if (currentNode.Left != null)
            {
                PostOrder(currentNode.Left); // Recursively traverse left
            }

            if (currentNode.Right != null)
            {
                PostOrder(currentNode.Right); // Recursively traverse right
            }

            Console.Write(currentNode.Data + " "); // Print current node
        }

        // Wrapper method for Postorder Traversal
        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }

        // Method to delete a node from the BST
        public Node deleteNode(Node currentNode, int data)
        {
            if (currentNode == null) return null; // Base case: tree is empty

            if (data < currentNode.Data) // Look in the left subtree
            {
                currentNode.Left = deleteNode(currentNode.Left, data);
            }
            else if (data > currentNode.Data) // Look in the right subtree
            {
                currentNode.Right = deleteNode(currentNode.Right, data);
            }
            else
            {
                // Case 1: Node has no children (leaf node)
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    currentNode = null;
                    return null;
                }
                // Case 2: Node has one child (right)
                else if (currentNode.Left == null)
                {
                    Node temp = currentNode.Right;
                    currentNode = null;
                    return temp;
                }
                // Case 2: Node has one child (left)
                else if (currentNode.Right == null)
                {
                    Node temp = currentNode.Left;
                    currentNode = null;
                    return temp;
                }
                // Case 3: Node has two children
                else
                {
                    int subTreeMin = minValue(currentNode.Right); // Find min value in right subtree
                    currentNode.Data = subTreeMin; // Replace current node with min value
                    currentNode.Right = deleteNode(currentNode.Right, subTreeMin); // Delete min node
                }
            }
            return currentNode;
        }

        // Wrapper method to start deletion from root
        public void deleteNode(int value)
        {
            root = deleteNode(root, value);
        }

        // Helper function to find the minimum value in a subtree
        public int minValue(Node currentNode)
        {
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left; // Move left until the last node
            }
            return currentNode.Data; // Return the leftmost node's value
        }
    }
}
