using System;
using System.Collections.Generic;

namespace Felizes_Sortudos.Service
{
    public class EFelizServices
    {
        public string Feliz(int numero)
        {
            return VerificarNumero(numero);
        }

        public string VerificarNumero(int numero)
        {
            string numeroFeliz = $"O número " + numero + " não é feliz";
            int count = 0;
            List<int> lista = new List<int>();
            lista = Dividir(numero);
            for (int i = 0; i < 100 && count == 0; i++)
            {
                int somaAtual = Quadrados(lista);
                if (somaAtual != 1)
                    lista = Dividir(somaAtual);

                if (somaAtual == 1) {
                    numeroFeliz = $"O número " + numero + " é feliz";
                    count++;
                }
            }
            return numeroFeliz;
        }

        public int Quadrados(List<int> lista)
        {
            int resultado = 0;
            foreach (int item in lista) {
                resultado += item * item;
            }
            return resultado;
        }

        public List<int> Dividir(int digito)
        {
            List<int> digitos = new List<int>();
            while (digito != 0)
            {
                digitos.Add(digito % 10);
                digito = digito / 10;
            }
            return digitos;
        }
    }
}
