using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_JTramon
{
    class Persona
    {
        public string name;
        public string lastname;

        public Persona(string n, string l)
        {
            name = n;
            lastname = l;

        }

        public int Lanzar()
        {
            Random rnd = new Random();
            int number;

            number = rnd.Next(0, 3);

            return number;

        }
    }                
    
}
