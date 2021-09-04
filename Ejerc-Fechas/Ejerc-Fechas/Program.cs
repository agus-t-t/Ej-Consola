using System;
using System.Globalization;

namespace Ejerc_Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej24();
        }

        public static void Ej21()
        {
            //21. Presente al usuario la fecha actual.
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }

        public static void Ej22()
        {
            //22. Presente al usuario la fecha actual con el siguiente formato: dd/MM/yyyy
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
        }

        public static void Ej23()
        {
            //23. Solicite el ingreso de una fecha al usuario y determine si es un ingreso válido.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }
                
                DateTime hoy = DateTime.Now;

                if (fecha.Year > hoy.Year)
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                if (fecha.Year == hoy.Year && fecha.Month > hoy.Month)
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                if (fecha.Year == hoy.Year && fecha.Month == hoy.Month && fecha.Day > hoy.Day)
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                Console.WriteLine("La fecha ingresada es válida");

                programa = false;

            } while (programa);
        }

        public static void Ej24()
        {
            //24. Solicite el ingreso de una fecha al usuario utilizando, estrictamente, el formato dd/MM/yyyy
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha con el siguiente formato: dd/mm/aaaa");
                string ingreso = Console.ReadLine();

                string formato = "dd/MM/yyyy";

                if (!DateTime.TryParseExact(ingreso, formato, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out DateTime fecha))
                {
                    Console.WriteLine("La fecha ingresada es incorrecta o el formato es inválido");
                    continue;
                }

                Console.WriteLine(fecha);

                programa = false;

            } while (programa);
        }
}
