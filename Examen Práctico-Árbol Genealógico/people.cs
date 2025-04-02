using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class person
    {
       
        private string name;
        private person mother;
        private person father;
         

       
        public person(string name)
        {
            this.name = name;
            mother = null;
            father = null; 
        }
        
        public int Mother
        {
            get { return Mother; }
            set { Mother = value; }
        }

        public int Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Father
        {
            get { return Father; }
            set { Father = value; }
        }



    }
}
