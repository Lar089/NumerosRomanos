using NumerosRomanos.ConsoleApp.Numeros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new Numeros.NumerosRomanos("X̄").numeros_saida);
            Console.WriteLine(new Numeros.NumerosArabicos(568).numeros_saida);
            Console.ReadLine();
        }
    }
}
