using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAcumulado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Perro = new Animal("Porqui", 25.5);


            Console.WriteLine(Perro.nombre);
            Console.WriteLine("Este es mi proyecto");

            Console.ReadLine();
        }
    }
}
