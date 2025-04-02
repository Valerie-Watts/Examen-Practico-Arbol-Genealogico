using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class person
    {
        //Estan en público para no complicarme :(
        public string name;
        public person mother;
        public person father; 

     
        //Primer constructor que inicializa a persona con un nombre
        public person(string name) 
        {
            this.name = name;
            mother = null;
            father = null;
        }


    }
}
