using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAcumulado
{
    internal class Gato:Animal
    {
        public string raza {  get; set; }
        public Gato( string nombre, double peso, string raza) :base(nombre, peso)
        {
            this.raza = raza;
        }

        public void Sonido()
        {
            Console.WriteLine("El gato hace miaw!");
        }
    }
}
