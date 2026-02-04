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
            Gato Minino = new Gato("Minino",25.5,"Come cuando hay!" );

            Console.WriteLine( $"El gato se llama {Minino.nombre} y es de raza {Minino.raza}");


     
            Console.WriteLine("Este es mi proyecto practica");

            Console.ReadLine();
        }
    }
}
