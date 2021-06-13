using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.ConsoleApp.Numeros
{
    public class NumerosRomanos : DefinicaoNumerosRomanos
    {
        private char[] lista_valores;
        public int numeros_saida;
        public int valor_anterior = 0;
        private int contador = 0;

        public NumerosRomanos(string numeros)
        {
            numeros = SubstituirTermosRomanos(numeros);
            this.lista_valores = numeros.ToCharArray();
            this.numeros_saida = GerarNumerosArabicos(lista_valores);
        }

        private int GerarNumerosArabicos(char[] lista_valores)
        {
            char[] letras = lista_valores;
            int valores = 0;
            int valor_posicao = 0;
            numerosRomanos = new List<int>();

            for (int i = 0; i < letras.Length; i++)
            {
                valores = VerificaLetraRomana(letras[i].ToString());

                if (valores == -1)
                    return -1;

                else if (i < letras.Length && i + 1 < letras.Length)
                {
                    valor_posicao = VerificaProximaPosicao(letras, letras[i].ToString());

                    if (valor_posicao != valores)
                    {
                        valores = valor_posicao;
                        i++;
                    }
                    numerosRomanos.Add(valores);
                }
                else
                {
                    numerosRomanos.Add(valores);
                }
            }
            valores = GerarValorFinal();
            return valores;
        }

        private int VerificaLetraRomana(string letra)
        {
            int valor_reposta = 0;
            string validar = "RESPOSTA_VALIDA";

            foreach (string item in baseNumerosRomanos.Keys)
            {
                int valor_atual = baseNumerosRomanos[letra];
                if (letra.Equals(item))
                {
                    if (valor_anterior == valor_atual)
                    {
                        contador++;
                        validar = VericarQuantidadeRepeticao(contador, letra);
                    }
                    else
                        contador = 0;

                    valor_anterior = valor_atual;

                    valor_reposta = VerificaReposta(validar, valor_atual);

                    return valor_reposta;
                }
            }
            return valor_reposta;
        }

        private string VericarQuantidadeRepeticao(int contador, string letra)
        {
            if (contador > 2)
                return "RESPOSTA_INVALIDA";
            else if (letra == "V" || letra == "L" || letra == "D")
                return "RESPOSTA_INVALIDA";
            else
                return "RESPOSTA_VALIDA";
        }

        private int VerificaReposta(string validar, int valor_atual)
        {
            return validar != "RESPOSTA_VALIDA" ? -1 : valor_atual;
        }

        public int VerificaProximaPosicao(char[] letras, string letra_atual)
        {
            int valor_atual = baseNumerosRomanos[letra_atual];
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i].ToString().Equals(letra_atual))
                {
                    int valor_posterior = baseNumerosRomanos[letras[i + 1].ToString()];

                    if (valor_atual == valor_posterior)
                        return valor_atual;
                    else
                        return valor_atual = VerificaValoresParaSubtrair(valor_posterior, valor_atual);
                }
            }

            return valor_atual;
        }

        public int VerificaValoresParaSubtrair(int valor_posterior, int valor_atual)
        {
            int valor = valor_atual;
            foreach (int item in valoresDeSubtracao.Values)
            {
                if (valor_atual == item)
                {
                    return valor = valor_atual >= valor_posterior ? valor_atual : valor_posterior - valor_atual;
                }
            }
            return valor;
        }

        private int GerarValorFinal()
        {
            int valor_final = 0;
            foreach (int item in numerosRomanos)
            {
                valor_final += item;
            }
            return valor_final;
        }
    }

}
