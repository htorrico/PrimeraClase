using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraClase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            // TipoDato NombreVariable ;
            int edad=33;
            string nombre = "Hugo";
            double sueldo = 10000.0;
            bool EsMayorEdad = true;
            string seccion = "J";



            //DateTime FechaNacimiento = "05-04-1988";
            //Char existe pero no lo vamos usar


            Console.WriteLine("Mi nombre es " + nombre);
            Console.WriteLine("Mi edad es " + edad);
            Console.WriteLine("Mi sueldo es " + sueldo);

            if (edad>18)
            {
                Console.WriteLine("Es Mayor De Edad");
            }
            else
            {
                Console.WriteLine("Es Menor De Edad");
            }


            switch (seccion)
            {
                case "A":
                    Console.WriteLine("Turno Mañana");
                    break;
                case "B":
                    Console.WriteLine("Turno Tarde");
                    break;
                case "C":
                    Console.WriteLine("Turno Noche");
                    break;

                default:
                    Console.WriteLine("No encuentro el turno");
                    break;
            }








            //Pausa
            Console.Read();






        }
    }
}
