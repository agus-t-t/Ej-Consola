using System;
using System.Globalization;

namespace Ejerc_Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej29();
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

        public static void Ej25()
        {
            //25. Le solicite al usuario el ingreso de tres números y determine si conforman una fecha válida interpretados como día / mes / año.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese tres números");
                string num1 = Console.ReadLine();
                string num2 = Console.ReadLine();
                string num3 = Console.ReadLine();
                string ingresoPosibleFecha = $"{num1} {num2} {num3}";

                if (!DateTime.TryParse(ingresoPosibleFecha, out DateTime fecha))
                {
                    Console.WriteLine("Los números ingresados no son una fecha");
                    continue;
                }

                Console.WriteLine($"Los números ingresados son una fecha: {fecha}");
                programa = false;
            } while (programa);
        }

        public static void Ej26()
        {
            //26. Solicite el ingreso de una fecha al usuario y le presente: el día, el año, el número y nombre del mes y el nombre y número del día de la semana.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");

                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                Console.WriteLine($"Día: {fecha.Day}\n" +
                    $"Año: {fecha.Year}\n" +
                    $"Número del mes: {fecha.Month}\n" +
                    $"Nombre del mes: {fecha.ToString("MMMM")}\n" +
                    $"Nombre del día de la semana: {fecha.ToString("dddd")}\n" +
                    $"Número del día de la semana: {(int)fecha.DayOfWeek + 1}\n");

                programa = false;

            } while (programa);
        }

        public static void Ej27()
        {
            //27. Solicite el ingreso de una fecha al usuario y presente las fechas 30, 60, 90 y 180 días posteriores a la ingresada.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");

                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                Console.WriteLine($"30 días después: {fecha.AddDays(30)}\n" +
                    $"60 días después: {fecha.AddDays(60)}\n" +
                    $"90 días después: {fecha.AddDays(90)}\n" +
                    $"180 días después: {fecha.AddDays(180)}\n");

                programa = false;

            } while (programa);
        }

        public static void Ej28()
        {
            //28. Solicite el ingreso de un número al usuario y determine si corresponde a un año bisiesto.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese un número");

                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("No ingresó un número válido");
                    continue;
                }

                if (numero % 4 == 0)
                {
                    if (numero % 100 != 0 || numero % 400 == 0)
                        Console.WriteLine("Es un año bisiesto");
                    
                }

                else
                    Console.WriteLine("No es un año bisiesto");

                programa = false;
            } while (programa);
            
        }

        public static void Ej29()
        {
            //29. Solicite el ingreso de una fecha al usuario y presente la fecha correspondiente al primero de mes inmediato anterior.
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha");

                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                int numeroDias = fecha.Day - (fecha.Day - 1);

                DateTime nuevaFecha = fecha.AddMonths(1);

                Console.WriteLine($"{numeroDias}/{nuevaFecha.Month}/{nuevaFecha.Year}");

                programa = false;

            } while (programa);
        }

        public static void Ej30()
        {
            //30. Solicite el ingreso de una fecha al usuario y muestre sólo la hora. 
            bool programa = true;
            do
            {
                Console.WriteLine("Ingrese una fecha y hora");

                if (!DateTime.TryParse(Console.ReadLine(), out DateTime fecha))
                {
                    Console.WriteLine("La fecha ingresada no es válida");
                    continue;
                }

                Console.WriteLine(fecha.ToString("hh:mm:ss"));

                programa = false;

            } while (programa);
        }
    }
}
