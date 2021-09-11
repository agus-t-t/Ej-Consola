using System;

namespace Ejerc_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej33();
        }

        public static void Ej31()
        {
            //31. Solicite un ingreso al usuario y determine si puede interpretarse como un intervalo de tiempo. 
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese un intervalo de tiempo");
                if (!TimeSpan.TryParse(Console.ReadLine(), out TimeSpan intervalo))
                {
                    Console.WriteLine("Usted no ingresó un intervalo de tiempo");
                    continue;
                }

                Console.WriteLine("Usted ingresó un intervalo de tiempo");
                programa = false;

            } while (programa);
        }

        public static void Ej32()
        {
            //32. Solicite el ingreso de dos fechas al usuario y determine el intervalo en días, meses y años. 
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha1))
                {
                    Console.WriteLine("No ingresó una fecha");
                    continue;
                }

                Console.WriteLine("Ingrese otra fecha");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha2))
                {
                    Console.WriteLine("No ingresó una fecha");
                    continue;
                }

                TimeSpan intervalo;

                if (fecha1 > fecha2)
                    intervalo = fecha1 - fecha2;

                else
                    intervalo = fecha2 - fecha1;

                Console.WriteLine($"Intervalo en días: {intervalo.TotalDays}\n" +
                    $"Intervalo en meses: {intervalo.TotalDays / 30}\n" +
                    $"Intervalo en años: {intervalo.TotalDays / 365}");

                programa = false;

            } while (programa);
        }

        public static void Ej33()
        {
            //33. Solicite el ingreso de una fecha al usuario y determine cuántos días restan para el fin de año próximo más cercano. 
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("No ingresó una fecha");
                    continue;
                }

                DateTime finDeAno = new DateTime(fecha.Year, 12, 31, 0, 0, 0);
                TimeSpan intervalo = finDeAno - fecha;

                Console.WriteLine($"Días restantes para fin de año del año ingresado: {intervalo.TotalDays}");

                programa = false;

            } while (programa);
        }
    
    }
}
