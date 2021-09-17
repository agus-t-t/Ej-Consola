using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejerc_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej43();
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
                {
                    ingresando = false;
                    break;
                }
                    

                numeros.Add(numero);
            } while (ingresando);

            if (numeros.Count() > 0)
            {
                int suma = 0;

                foreach (int numero in numeros)
                {
                    suma += numero;
                }

                int promedio = suma / numeros.Count();

                Console.WriteLine($"El máximo: {numeros.Max()}\n" +
                    $"El mínimo: {numeros.Min()}\n" +
                    $"El promedio: {promedio}\n" +
                    $"La suma: {suma}");
            }

            else
            {
                Console.WriteLine("No se ingresaron números a la serie");
            }

        }

        public static void Ej45()
        {
            //45. Realizar una aplicación que solicite el ingreso de una serie de números de registro y nombres de alumno, hasta que el usuario ingrese el registro “0”.
            bool ingresando = true;
            IDictionary<int, string> registros = new Dictionary<int, string>();
            do
            {
                Console.WriteLine("Ingrese un número de registro su nombre asociado. Hágalo hasta ingresar un '0'. Ingrese el número de registro y el nombre separados por un espacio");

                string ingreso = Console.ReadLine();

                if (ingreso == "0")
                {
                    ingresando = false;
                    break;
                }

                string[] items = ingreso.Split(' ');

                if(items.Length != 2)
                {
                    Console.WriteLine("No ingresó los datos correctamente");
                    continue;
                }

                else if (!int.TryParse(items[0], out int registro)){
                    Console.WriteLine("No ingresó los datos correctamente");
                    continue;
                }

                registros.Add(registro, items[1]);

            } while (ingresando);
        }
    }
}
