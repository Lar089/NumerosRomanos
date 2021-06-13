using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp.Numeros
{
    public class NumerosArabicos : DefinicaoNumerosRomanos
    {
        private int valor;
        public string numeros_saida;
        private int VALOR_DIVISAO = 10000;
        List<int> lista_valor;


        public NumerosArabicos(int numeros)
        {
            lista_valor = new List<int>();
            this.valor = numeros;
            this.numeros_saida = GerarNumerosRomanos(valor);
            numeros_saida = SubstituirTermosParaRomano(numeros_saida);
        }

        private string GerarNumerosRomanos(int valor)
        {
            string numeros_romanos = "";
            valor = DefinirValor(valor);

            

            if (valor == 0)
                numeros_romanos = GerarNumeros();

            return numeros_romanos;
        }

        private string GerarNumeros()
        {
            string numeros_romanos = "";

            foreach (int item in lista_valor)
            {
                bool conseguiu = false;
                foreach (int valor in numerosRomanoParaArabicos.Keys)
                {
                    if (item.Equals(valor))
                    {
                        numeros_romanos += numerosRomanoParaArabicos[valor];
                        conseguiu = true;
                        break;
                    }
                }

                if (!conseguiu)
                        numeros_romanos += EncontrarValores(item);
            }
            return numeros_romanos;
        }

        private string EncontrarValores(int item)
        {
            string numeros_romanos = "";
            foreach (int valor in numerosRomanoParaArabicos.Keys)
            {
                if(item > valor)
                {
                    foreach (int numero in valoresDeSubtracao.Values)
                    {
                        if(item > numero)
                            return numeros_romanos += NumeroRepeticao(item, valor, numero);
                    }
                }
            }

            return numeros_romanos;
        }

        private string NumeroRepeticao(int item, int valor, int numero)
        {
            string numeros_romanos = "";
            foreach (int m_valores in valoresDeMultiplicacao.Keys)
            {
                if (item == (valor - numero))
                    return numeros_romanos = GerarLetraRomana(item, m_valores);

                else if (item == (valor + m_valores))
                    return numeros_romanos = GerarLetraRomana(valor, m_valores);
            }

            return numeros_romanos;
        }

        private string GerarLetraRomana(int item, int numero)
        {
            string numeros_romanos = "";
            foreach (int valor in numerosRomanoParaArabicos.Keys)
            {
                if (item.Equals(valor))
                    numeros_romanos += numerosRomanoParaArabicos[valor];
                
                if (numero.Equals(valor))
                    numeros_romanos += numerosRomanoParaArabicos[valor];
            }

            return numeros_romanos;
        }

        private int DefinirValor(int valor)
        {
            int resto_divisao = valor % VALOR_DIVISAO;

            if (resto_divisao != 0)
            {
                VALOR_DIVISAO = VALOR_DIVISAO / 10;

                if (resto_divisao != valor)
                    lista_valor.Add(valor - resto_divisao);

                resto_divisao = DefinirValor(resto_divisao);
            }
            else
            {
                lista_valor.Add(valor);
            }

            return resto_divisao;
        }

    }
}
