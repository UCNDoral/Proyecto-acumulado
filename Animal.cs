using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAcumulado
{
    internal class Animal
    {
        public string nombre {  get; set; }
        public string edad {  get; set; }
        public double peso { get; set; }

        public Animal(string nombre , double peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }
        public void sonido()
        {

            Console.WriteLine("el animal hace un sonido");


        }

    }









}
