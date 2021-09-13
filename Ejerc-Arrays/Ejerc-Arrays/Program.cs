using System;
using System.Collections.Generic;

namespace Ejerc_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej42();
        }

        public static void Ej39()
        {
            //39. Solicite el ingreso de una serie de números al usuario y los presente en orden inverso. 
            Console.WriteLine("Ingrese una serie de números, separándolos con espacio");
            string ingreso = Console.ReadLine();
            string[] posiblesNumeros = ingreso.Split(" ");
            List<int> numeros = new List<int>();
            List<int> numerosInv = new List<int>();
            for (int i = 0; i < posiblesNumeros.Length; i++)
            {
                if (int.TryParse(posiblesNumeros[i], out int numero))
                {
                    numeros.Add(numero);
                }
            }

            for (int i = numeros.Count - 1; i >= 0; i--)
            {
                numerosInv.Add(numeros[i]);
            }

            Console.WriteLine(String.Join(" ", numerosInv));
        }

        public static void Ej40()
        {
            //40. Solicite el ingreso de una frase al usuario y presente cada palabra en una línea por separado.
            Console.WriteLine("Ingrese una frase");
            string ingreso = Console.ReadLine();
            string[] frase = ingreso.Split(" ");
            foreach (string palabra in frase)
            {
                Console.WriteLine(palabra);
            }
        }

        public static void Ej41()
        {
            //41. Solicite el ingreso de una serie de fechas al usuario y las presente ordenadas en forma ascendente. 
            Console.WriteLine("Ingrese una serie de fechas");
            

        }

        public static void Ej42()
        {
            //42. Solicite el ingreso de una palabra al usuario y la presente escrita al revés. 
            Console.WriteLine("Ingrese una palabra");
            string ingreso = Console.ReadLine();
            char[] palabra = ingreso.ToCharArray();
            List<char> palabraInv = new List<char>();
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                palabraInv.Add(palabra[i]);
            }

            string salida = new string (palabraInv.ToArray());
            Console.WriteLine(String.Join("", salida));
        }

        public static void Ej43()
        {
            //43. Solicite el ingreso de una serie de números hasta que el usuario ingrese -1. Luego presentar: el máximo, el mínimo, el promedio, la suma.
            //Realizar todos los cálculos una vez finalizado el ingreso. 
            Console.WriteLine("Ingrese una serie de números se termina cuando ingresa -1");
            bool ingresando = true;
            List<int> numeros = new List<int>();
            do
            {
                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Usted no ingresó un número");
                    continue;
                }

                else if (numero == -1)
                    ingresando = false;

                numeros.Add(numero);
            } while (ingresando);

            Console.WriteLine($"El máximo: {numeros.Max()}")
        }
    }
}
