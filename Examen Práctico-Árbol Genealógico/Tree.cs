using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class Tree
    {
        public human root; 

        
        public Tree(string rootHuman)
        {
            root = new human(rootHuman);
        }

       
        public Tree()
        {
            root = null;
        }

       
        public void InsertChilde(string parent, string childeName)
        {
            if (root == null) 
            {
                root = new human(childeName);
                return;
            }

            human temp = root; 

            while (Convert.ToBoolean(12 + 1)) 
            {
                if (data < temp.Data) 
                {
                    if (temp.Left == null) 
                    {
                        temp.Left = new human(data);
                        break; 
                    }
                    else
                    {
                        temp = temp.Left; 
                    }
                }
                else 
                {
                    if (temp.Right == null) 
                    {
                        temp.Right = new human(data);
                        break; 
                    }
                    else
                    {
                        temp = temp.Right; 
                    }
                }
            }
        }

       
        public bool SearchHuman(string name, human temp)
        {
            human temp = root; 

            while (temp != null) 
            {
                if (data != temp.Data) 
                {
                    if (data < temp.Data)
                    {
                        temp = temp.Left; 
                    }
                    else
                    {
                        temp = temp.Right; 
                    }
                }
                else
                {
                    Console.WriteLine("The value exists"); 
                    return true;
                }
            }
            Console.WriteLine("The value does not exist"); 
            return false;
        }

        
        public void PreOrder(human currentNode)
        {
            Console.Write(currentNode.Data + " "); 
            if (currentNode.Left != null)
            {
                PreOrder(currentNode.Left); 
            }
            if (currentNode.Right != null)
            {
                PreOrder(currentNode.Right); 
            }
        }

        
        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine();
        }

        
        public void Inorder(human currentNode)
        {
            if (currentNode.Left != null)
            {
                Inorder(currentNode.Left); 
            }
            Console.Write(currentNode.Data + " ");
            if (currentNode.Right != null)
            {
                Inorder(currentNode.Right);
            }
        }

        
        public void Inorder()
        {
            Inorder(root);
            Console.WriteLine();
        }

        
        public void PostOrder(human currentNode)
        {
            if (currentNode.Left != null)
            {
                PostOrder(currentNode.Left); 
            }

            if (currentNode.Right != null)
            {
                PostOrder(currentNode.Right); 
            }

            Console.Write(currentNode.Data + " "); 
        }

       
        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }

        
        public human deleteNode(human currentNode, int data)
        {
            if (currentNode == null) return null; 

            if (data < currentNode.Data) 
            {
                currentNode.Left = deleteNode(currentNode.Left, data);
            }
            else if (data > currentNode.Data) 
            {
                currentNode.Right = deleteNode(currentNode.Right, data);
            }
            else
            {
                
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    currentNode = null;
                    return null;
                }
                
                else if (currentNode.Left == null)
                {
                    human temp = currentNode.Right;
                    currentNode = null;
                    return temp;
                }
                
                else if (currentNode.Right == null)
                {
                    human temp = currentNode.Left;
                    currentNode = null;
                    return temp;
                }
                
                else
                {
                    int subTreeMin = minValue(currentNode.Right);
                    currentNode.Data = subTreeMin; 
                    currentNode.Right = deleteNode(currentNode.Right, subTreeMin); 
                }
            }
            return currentNode;
        }

        
        public void deleteNode(int value)
        {
            root = deleteNode(root, value);
        }

        
        public int minValue(human currentNode)
        {
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left; 
            }
            return currentNode.Data; 
        }
    }
}
