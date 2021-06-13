using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp.Numeros
{
    public class DefinicaoNumerosRomanos
    {
        public static List<int> numerosRomanos;

        public static Dictionary<string, int> baseNumerosRomanos = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
            { "i", 1000 },
            { "v", 5000 },
            { "x", 10000 },
            { "l", 50000 },
            { "c", 100000 },
            { "d", 500000 },
            { "m", 1000000}
        };

        public static Dictionary<string, int> valoresDeSubtracao = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "X", 10 },
            { "C", 100 },
            { "i", 1000 },
            { "x", 10000 },
            { "c", 100000 },
        };

        public static Dictionary<int, string> valoresDeMultiplicacao = new Dictionary<int, string>()
        {
            { 300, "CCC"},
            { 200, "CC"},
            { 100, "C"},
            { 30, "XXX"},
            { 20, "XX"},
            { 10, "X"},
            { 3, "III"},
            { 2, "II"},
            { 1, "I"}
        };

        public static Dictionary<int, string> numerosRomanoParaArabicos = new Dictionary<int, string>()
        {

            { 1000000, "M̄" },
            { 900000, "C̄M̄" },
            { 500000, "D̄" },
            { 400000, "C̄D̄" },
            { 100000, "C̄"},
            { 90000, "X̄C̄" },
            { 50000, "L̄" },
            { 40000, "X̄L̄" },
            { 10000, "X̄" },
            { 9000, "ĪX̄" },
            { 5000, "V̄" },
            { 4000, "ĪV̄" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD"},
            { 300, "CCC"},
            { 200, "CC"},
            { 100, "C"},
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 30, "XXX"},
            { 20, "XX"},
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 4, "IV"},
            { 3, "III"},
            { 2, "II"},
            { 1, "I"},
        };

        public string SubstituirTermosRomanos(string termos)
        {
            termos = termos.Replace("Ī", "i");
            termos = termos.Replace("X̄", "x");
            termos = termos.Replace("V̄", "v");
            termos = termos.Replace("C̄", "c");
            termos = termos.Replace("D̄", "d");
            termos = termos.Replace("L̄", "l");
            termos = termos.Replace("M̄", "m");

            return termos;
        }

        public string SubstituirTermosParaRomano(string termos)
        {
            termos = termos.Replace("i", "Ī");
            termos = termos.Replace("x", "X̄");
            termos = termos.Replace("v", "V̄");
            termos = termos.Replace("c", "C̄");
            termos = termos.Replace("d", "D̄");
            termos = termos.Replace("l", "L̄");
            termos = termos.Replace("m", "M̄");

            return termos;
        }

    }
}
