using System;

namespace Ejerc_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Ej06();
        }

        public static void Ej01()
        {
            //1. Presente el mensaje “Hola mundo” al usuario, espere la presión de una tecla y finalice.
            Console.WriteLine("Hola mundo");
            Console.ReadKey();
        }

        public static void Ej02()
        {
            //2. Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.
            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();
            Console.WriteLine($"El texto ingresado es: {texto}");
            Console.ReadKey();
        }

        public static void Ej03()
        {
            //3. Lea las teclas presionadas y finalice al presionar la tecla “X”.
            bool programa = true;
            while (programa)
            {
                Console.WriteLine("\nEl programa se cerrará solo si pulsa la tecla X");
                if (Console.ReadKey().Key == ConsoleKey.X)
                {
                    programa = false;
                }
            }
        }

        public static void Ej04()
        {
            //4. Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.
            bool programa = true;
            while (programa)
            {
                Console.WriteLine("\nEl programa se cerrará solo si ingresa la frase 'fin'");
                if (Console.ReadLine().ToUpper() == "FIN")
                {
                    programa = false;
                }
            }
        }

        public static void Ej05()
        {
            //5. Lea las teclas presionadas y finalice al presionar Ctrl+F (Ctrl y F al mismo tiempo).
            bool programa = true;
            Console.TreatControlCAsInput = true;
            while (programa)
            {
                Console.WriteLine("\nEl programa se cerrará solo si pulsa las tecla 'Ctrl' y 'F' juntas");
                ConsoleKeyInfo tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.F && tecla.Modifiers == ConsoleModifiers.Control)
                {
                    programa = false;
                }
            }
        }
    }

}



