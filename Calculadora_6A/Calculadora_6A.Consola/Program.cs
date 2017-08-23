using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6A.Libreria;

namespace Calculadora_6A.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos misMetodos = new Metodos();
            Console.WriteLine(misMetodos.Saludo());
            Console.WriteLine(misMetodos.Sumar(1, 9));
            Console.WriteLine(misMetodos.Restar(101, 1));
            Console.WriteLine(misMetodos.Multiplicar(10, 100));
            Console.WriteLine(misMetodos.Dividir(1000, 10));
            Console.ReadKey();
        }
    }
}
