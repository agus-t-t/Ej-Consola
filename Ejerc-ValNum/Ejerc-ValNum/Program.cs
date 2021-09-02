using System;

namespace Ejerc_ValNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej20();
        }

        public static void Ej15()
        {
            //15. Solicite un ingreso al usuario y determine si puede ser interpretado como un valor numérico.
            Console.WriteLine("Ingrese un texto. El sistema devolverá si puede ser interpretado como número");
            if (!decimal.TryParse(Console.ReadLine(), out decimal ingreso))
                Console.WriteLine("No pudo ser interpretado como número");
            else
                Console.WriteLine("Pudo ser interpretado como número");

        }

        public static void Ej16()
        {
            //16. Solicite un ingreso al usuario y determine si puede ser interpretado como un número entero.
            Console.WriteLine("Ingrese un texto. El sistema devolverá si puede ser interpretado como número entero");
            if (!int.TryParse(Console.ReadLine(), out int ingreso))
                Console.WriteLine("No pudo ser interpretado como número entero");
            else
                Console.WriteLine("Pudo ser interpretado como número entero");
        }

        public static void Ej17()
        {
            //17. Solicite el ingreso de dos números al usuario y presente la suma, la resta, la multiplicación, la división, el resto, el primero elevado a la potencia del segundo.
            Console.WriteLine("Ingrese un número");
            double numero1 = ValidarNumero(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            double numero2 = ValidarNumero(Console.ReadLine());
            double potencia = Math.Pow(numero1, numero2);
            Console.WriteLine($"\nLa suma de los dos números ingresados es: {numero1 + numero2}");
            Console.WriteLine($"La resta de los dos números ingresados es: {numero1 - numero2}");
            Console.WriteLine($"El producto de los dos números ingresados es: {numero1 * numero2}");
            Console.WriteLine($"El cociente de los dos números ingresados es: {numero1 / numero2}");
            Console.WriteLine($"El resto de los dos números ingresados es: {numero1 % numero2}");
            Console.WriteLine($"El primer número elevado al segundo es: {potencia}");
        }

        public static void Ej18()
        {
            //18. Solicite el ingreso de un número al usuario y lo presente redondeado a dos decimales.
            Console.WriteLine("Ingrese un número, se redondeará a dos decimales");
            double numero = ValidarNumero(Console.ReadLine());
            Console.WriteLine(Math.Round(numero, 2));
        }

        public static void Ej19()
        {
            //19. Solicite el ingreso de un número al usuario y presente la parte entera.
            Console.WriteLine("Ingrese un número, se redondeará el número");
            double numero = ValidarNumero(Console.ReadLine());
            Console.WriteLine(Math.Floor(numero));
        }

        public static void Ej20()
        {
            //20. Solicite el ingreso de 2 números al usuario y determine el mayor.
            Console.WriteLine("Ingrese un número");
            double numero1 = ValidarNumero(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            double numero2 = ValidarNumero(Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine("El primer número es mayor");

            else if (numero1 < numero2)
                Console.WriteLine("El segundo número es mayor");

            else
                Console.WriteLine("Los dos números son iguales");
        }


        public static double ValidarNumero(string ingreso)
        {
            bool check = true;
            double num = 0;
            while (check)
            {
                if (!double.TryParse(ingreso, out num))
                {
                    Console.WriteLine("Por favor ingrese una opción válida");
                    ingreso = Console.ReadLine();
                }

                else
                {
                    check = false;
                }
            }

            return num;
        }
    }
}
