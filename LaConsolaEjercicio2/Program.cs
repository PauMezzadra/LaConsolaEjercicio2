using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsolaEjercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "";

            do
            {
                Console.WriteLine("Ingrese cualquier texto:");
                texto = Console.ReadLine().ToUpper();
                if (texto == "")
                {
                    Console.WriteLine("Debe ingresar al menos una palabra");
                }

            } while (texto == "");

            Console.WriteLine("Usted escribió: " + texto);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
