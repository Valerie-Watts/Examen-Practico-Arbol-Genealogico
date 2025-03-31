using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Práctico_Árbol_Genealógico
{
    class human
    {
       
        private string name;
        private List<human> childe;  

       
        public human(string name)
        {
            this.name = name;
            childe = new List<human>(); 
        }
        
        public int Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Childe
        {
            get { return Childe; }
            set { Childe = value; }
        }



    }
}
