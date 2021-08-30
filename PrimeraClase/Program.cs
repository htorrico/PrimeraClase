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


            //Sentencias IF
            if (edad>18)
            {
                Console.WriteLine("Es Mayor De Edad");
            }
            else
            {
                Console.WriteLine("Es Menor De Edad");
            }


            //Sentencias SWITCH
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
                case "D":
                    Console.WriteLine("Turno Madrugada");
                    break;
                case "E":
                    Console.WriteLine("Medio turno");
                    break;
                default:
                    Console.WriteLine("No encuentro el turno");
                    break;
            }


            //Bucles
            //For *****
            //While
            //Do While
            //For each ****

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine((i+1)*2);
            //}

            int numero = 8;

            Console.WriteLine("");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(numero * (i + 1));
            }

            Console.WriteLine("");
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine( numero+" X "+ i + " = " +  numero * i);
            }
            Console.WriteLine("");
            int j = 1;
            while (j <= 12)
            {
                Console.WriteLine(numero + " X " +j + " = " + numero *j);
                j++;//i = i + 1;
            }

            int nota1 = 10;
            int nota2 = 20;
            int nota3 = 20;
            int nota4 = 20;

            //Uso de arreglos
            int[] notas = new int[5];
            notas[0] = 12;
            notas[1] = 15;
            notas[2] = 15;
            notas[3] = 15;
            notas[4] = 20;

            int[] notas2 = new int[5] { 12, 13, 14, 15, 10 };

            //Console.WriteLine(notas[0]);
            //Console.WriteLine(notas[1]);
            //Console.WriteLine(notas[2]);
            //Console.WriteLine(notas[3]);
            //Console.WriteLine(notas[4]);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(notas[i]);
            }



            Console.WriteLine("");
            foreach (var item in notas)
            {
                Console.WriteLine(item);
            }








            //Pausa
            Console.Read();






        }
    }
}
