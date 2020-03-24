using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_JTramon
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Persona("Bob", "Kunga");
            Console.Write(p1.name+" lanza "+p1.Lanzar());
            Console.ReadLine();
        }
    }
}
