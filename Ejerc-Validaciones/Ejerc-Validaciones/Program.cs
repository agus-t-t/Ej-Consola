using System;
using System.Collections.Generic;

namespace Ejerc_Validaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej38();
        }

        public static void Ej35()
        {
            //35. Solicitar el ingreso de un número al usuario, repitiendo la operación (presentando un mensaje de error) hasta que el ingreso sea válido.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese un número");
                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Usted no ingresó un número");
                    continue;
                }

                Console.WriteLine(numero);
                programa = false;

            } while (programa);
        }

        public static void Ej36()
        {
            //36. Solicitar el ingreso de una fecha al usuario, repitiendo la operación (presentando un mensaje de error) hasta que el ingreso sea válido. 
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("Usted no ingresó una fecha");
                    continue;
                }

                Console.WriteLine(fecha);
                programa = false;

            } while (programa);
        }

        public static void Ej37()
        {
            //37. Solicitar el ingreso de una cadena al usuario, repitiendo la operación (presentando un mensaje de error) hasta que el ingreso sea válido. Debe tener entre 10 y 20 caracteres. 
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una cadena de texto entre 10 y 20 caracteres");
                string ingreso = Console.ReadLine();
                if (ingreso.Length < 10)
                {
                    Console.WriteLine("La cadena ingresada tiene menos de 10 caracteres");
                    continue;
                }

                else if (ingreso.Length > 20)
                {
                    Console.WriteLine("La cadena ingresada tiene más de 20 caracteres");
                    continue;
                }

                Console.WriteLine(ingreso);
                programa = false;

            } while (programa);
        }

        public static void Ej38()
        {
            //38. Solicitar el ingreso de una serie de números al usuario, donde cada número de la serie debe ser mayor al anterior. 
            Console.WriteLine("Ingrese una serie de numeros, donde cada número debe ser siguiente al anterior. Pulse 'X' para finalizar el ingreso");
            bool ingresando = true;
            List<int> serie = new List<int>();

            do
            {
                Console.WriteLine("Ingrese un número");
                string ingreso = Console.ReadLine();

                if (ingreso.ToUpper() == "X")
                {
                    Console.WriteLine("\nLos números ingresados fueron:");
                    foreach (int numerito in serie)
                    {
                        Console.WriteLine(numerito);
                    }
                    ingresando = false;
                }

                else if (!int.TryParse(ingreso, out int numero))
                {
                    Console.WriteLine("No ingresó un número");
                    continue;
                }

                else if (serie.Count == 0)
                    serie.Add(numero);

                else if (numero <= serie[serie.Count - 1])
                {
                    Console.WriteLine("El numero ingresado no es mayor al anterior ingresado");
                    continue;
                }

                else
                {
                    serie.Add(numero);
                }

            } while (ingresando);
        }

    }
}
