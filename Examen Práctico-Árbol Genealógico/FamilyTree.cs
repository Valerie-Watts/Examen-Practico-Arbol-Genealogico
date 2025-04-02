using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class FamilyTree
    {
        //usando un diccionario para almacenar los nombres de los miembros

        public Dictionary<string, person> members; 
        //pongo al primer hijo como raiz
        public person Root;

        //constructor para el arbol genealogíco
        public FamilyTree()
        {
            members = new Dictionary<string, person>(); //iniciar el diccionario
            Root = null; //poner raiz como nulo
        }


        public void Insert(string child, string mother, string father)//insertar a los miembros
        {
            if (!members.ContainsKey(child)) //si no contiene al nombre del niño se agrega
            {
                members[child] = new person(child);
            }

            if (!members.ContainsKey(mother)) // si no esta el nombre de la madre se agrega
            {
                members[mother] = new person(mother);
            }

            if (!members.ContainsKey(father)) // si no tiene papá, se agrega
            {
                members[father] = new person(father);
            }
        
            //aqui se asigna el nombre de el papá y la mamá a el hijo si ninguna de las otras condiciones se cumple
            members[child].mother = members[mother]; 
            members[child].father = members[father];

            if (Root == null) //si la raiz es nula entonces el primer hijo agregado sera la raiz
            {
                Root = members[child]; 
            }
        }

        //encontrar los papas de el niño
        public void FindParents(string name)
        {
            if (members.ContainsKey(name)) //si el nombre del niño está entonces se ejecuta el if
            {
                string mother;
                string father;

                if (members[name].mother != null) //si la mama del niño ingresado existe 
                {
                    mother = members[name].mother.name; //entonces se guarda el nombre de la mama en la variable
                }
                else
                {
                    mother = "No parent"; // si no se cumple no tiene mamá
                }

                if (members[name].father != null)// si el papa del niño existe
                {
                    father = members[name].father.name; //entonces se guarda el nombre del papa en la variable
                }
                else
                {
                    father = "No parent"; //si no, no tiene papa
                }
                //aqui se escriben los padres del niño
                Console.WriteLine("Padres de " + name + ": Madre --> " + mother + ", Padre ---> " + father);
            }
            else
            {
                Console.WriteLine( name + " is not in the tree"); //el niño no esta en el arbol
            }
        }

        public void PreOrder(person node) //usando recursión
        {
            if (node == null) //si el nodo está vacío entonces regresa
            {
                return;
            }
            else 
            {
                //se usa recursion para imprimir los nombres de los miembros
                Console.WriteLine(node.name);

                PreOrder(node.mother);

                PreOrder(node.father);
            }
                
        }

        public void PreOrder() //funcion que se utilizará en el programa
        {
            if (Root != null)
            {
                PreOrder(Root); //si la raíz no es nula entonces se ejecuta la recursión
            }
            else
            {
                Console.WriteLine("The tree is empty"); //si no el arbol esta vacío
            }
        }

    }
}
