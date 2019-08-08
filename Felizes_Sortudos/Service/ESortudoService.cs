using Felizes_Sortudos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Felizes_Sortudos.Service
{
    public class ESortudoService
    {
        public string Sortudo(FelizesSortudos viewModel)
        {
            return Sortudos(viewModel.Numero);
        }

        public string Sortudos(int numero)
        {
            List<int> lista = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                lista.Add(i);
            }

            lista.RemoveAll(x => (x % 2 == 0));
            lista = RemoverIndice(lista, 3);
            lista = RemoverIndice(lista, 7);

            return lista.Contains(numero) ? $"O número " + numero + " é sortudo" : $"O número " + numero + " não é sortudo";
        }

        private static List<int> RemoverIndice(List<int> lista, int multiplo)
        {
            var removerMulti = new List<int>();
            var count = 0;

            for (int i = 1; i < lista.Count; i++)
            {
                if (i % multiplo == 0)
                {
                    removerMulti.Add(i);
                }
            }

            foreach (var item in removerMulti)
            {
                lista.RemoveAt((item - 1) - count);
                count++;
            }

            return lista;
        }
    }
}
