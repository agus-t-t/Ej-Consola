using System;

namespace Ejerc_Cadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej11();
        }

        public static void Ej07()
        {
            //7.Solicite al usuario el ingreso de su nombre y presente el mensaje “Hola [nombre]”.
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"\nHola {nombre}");
        }

        public static void Ej08()
        {
            //8.Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna contiene la palabra “fin”.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una frase, el programa terminará si ingresa la palabra 'fin'");
                string frase = Console.ReadLine();
                if (frase.Contains("fin"))
                {
                    Console.ReadKey();
                    break;
                }
            } while (programa);
        }

        public static void Ej09()
        {
            //9. Solicite un ingreso al usuario y lo presente en mayúsculas.
            Console.WriteLine("Ingrese una frase, el programa lo presentará en mayúsculas.");
            string ingreso = Console.ReadLine().ToUpper();
            Console.WriteLine(ingreso);
            Console.ReadKey();
        }

        public static void Ej10()
        {
            //10. Solicite un ingreso al usuario y lo presente en minúsculas.
            Console.WriteLine("Ingrese una frase, el programa lo presentará en minúsculas.");
            string ingreso = Console.ReadLine().ToLower();
            Console.WriteLine(ingreso);
            Console.ReadKey();
        }

        public static void Ej11()
        {
            //10. Reemplace en una cadena ingresada por el usuario todas las vocales acentuadas por vocales sin acento y presente el resultado.
            Console.WriteLine("Ingrese una frase");
            string ingreso = Console.ReadLine();
            string ingresoA = ingreso.Replace("á", "a");
            string ingresoE = ingresoA.Replace("é", "e");
            string ingresoI = ingresoE.Replace("í", "i");
            string ingresoO = ingresoI.Replace("ó", "o");
            string ingresoU = ingresoO.Replace("ú", "u");
            Console.WriteLine(ingresoU);
        }

        public static void Ej12()
        {
            //12. Solicite el ingreso de dos frases y determine si son iguales.
            Console.WriteLine("Ingrese dos frases");
            string ingreso1 = Console.ReadLine();
            string ingreso2 = Console.ReadLine();

            if (ingreso1.Length != ingreso2.Length)
                Console.WriteLine("Las frases no son iguales");

            else
            {
                char[] frase1 = ingreso1.ToCharArray(0, ingreso1.Length);
                char[] frase2 = ingreso2.ToCharArray(0, ingreso2.Length);

                int contador = 0;

                for (int i = 0; i < frase1.Length; i++)
                {
                    if (frase1[i] == frase2[i])
                    {
                        contador++;
                    }
                }

                if (contador == frase1.Length)
                    Console.WriteLine("Las frases son iguales");

                else
                    Console.WriteLine("Las frases no son iguales");
            }
        }

        public static void Ej13()
        {
            //13. Solicite el ingreso de dos frases y determine si tienen la misma longitud.
            Console.WriteLine("Ingrese dos frases");
            string ingreso1 = Console.ReadLine();
            string ingreso2 = Console.ReadLine();

            if (ingreso1.Length != ingreso2.Length)
                Console.WriteLine("Las frases no tienen la misma longitud");

            else
                Console.WriteLine("Las frases tienen la misma longitud");
        }

        public static void Ej14()
        {
            //14. Solicite el ingreso de dos frases y determine si son iguales, sin diferenciar mayúsculas de minúsculas.
            Console.WriteLine("Ingrese dos frases");
            string ingreso1 = Console.ReadLine().ToUpper();
            string ingreso2 = Console.ReadLine().ToUpper();

            if (ingreso1.Length != ingreso2.Length)
                Console.WriteLine("Las frases no son iguales");

            else
            {
                char[] frase1 = ingreso1.ToCharArray(0, ingreso1.Length);
                char[] frase2 = ingreso2.ToCharArray(0, ingreso2.Length);

                int contador = 0;

                for (int i = 0; i < frase1.Length; i++)
                {
                    if (frase1[i] == frase2[i])
                    {
                        contador++;
                    }
                }

                if (contador == frase1.Length)
                    Console.WriteLine("Las frases son iguales");

                else
                    Console.WriteLine("Las frases no son iguales");
            }
        }
    }
}
