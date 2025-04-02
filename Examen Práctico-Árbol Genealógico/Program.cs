using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
            string child;
            string mother, father; 

            FamilyTree Tree = new FamilyTree(); //se crea el arbol

            while (true)
            {
                Console.WriteLine("\nFamily Tree!"); //opciones que se pueden usar en el arbol
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. Insert a member\n2. Show parents\n3. Print preorder\n4. Exit");
                opt = Convert.ToInt32(Console.ReadLine());
                //Se usan las funciones
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Insert the name of the Child: ");
                        child = Console.ReadLine();
                        Console.WriteLine("Insert the name of the Mother: ");
                        mother = Console.ReadLine();
                        Console.WriteLine("Insert the name of the Father: ");
                        father = Console.ReadLine();

                        Tree.Insert(child, mother, father);

                        break;
                    case 2:
                        Console.WriteLine("Insert the name of the child whose parents you want to find: ");
                        child = Console.ReadLine();

                        Tree.FindParents(child);

                        break;
                    case 3:
                        Tree.PreOrder();
                        break;
                    case 4:
                        return;

                }
            }
        }
    }
}
