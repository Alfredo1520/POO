using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.Write("introduce un numero: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("introduce un numero: ");
            B = Convert.ToInt32(Console.ReadLine());
            C = A + B;

            Console.WriteLine("la suma de los numeros es: " + C);
            Console.ReadKey();





        }
    }
}
