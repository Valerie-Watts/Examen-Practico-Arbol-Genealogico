using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class Node
    {
        // Class representing a node in the Binary Search Tree (BST)
        private int data; // Stores the node's value
        private Node left, right; // References to left and right child nodes

        // Constructor to initialize a node with data and child nodes
        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        // Constructor to initialize a node with data only (children set to null)
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

        // Property to get or set the node's value
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        // Property to get or set the left child node
        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        // Property to get or set the right child node
        public Node Right
        {
            get { return right; }
            set { right = value; }
        }


    }
}
