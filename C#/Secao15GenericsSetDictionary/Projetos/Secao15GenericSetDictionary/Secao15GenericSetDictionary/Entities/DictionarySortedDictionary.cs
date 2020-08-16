using System;
using System.Collections.Generic;
using System.Text;

namespace Secao15GenericSetDictionary.Entities
{
    class DictionarySortedDictionary
    {
        public static void Main(string[] args)
        {
            /*
             * Dictionary<TKey, TValue>
             * - É uma coleção de pares chave/valor
             * - - Não admite repetições de objeto chave
             * - - Os elementos são indexados pelo objeto chave (não possuem posição)
             * - - Acesso, inserção e remoção de elementos são rápidos
             * 
             * - Uso comun: cookies, local storage, qualquer modelo chave-valor
             * 
             *  -/ DIFERENÇAS \-
             *   - Dictionary
             *   - - Armazenamento em tabela hash
             *   - - Extremamente rápido: inserção, remoção e busca O(1)
             *   - - A ordem dos elementos não é garantida
             *   
             *   - SortedDictionary
             *   - - Armazenamento em árvore
             *   - - Rápido: inserção, remoção e busca O(log(n))
             *   - - Os elementos são armazenados ordenadamente conforme implementação
             *   - - IComparer<T>
             *   */

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "169938384";
            cookies["phone"] = "163912391";
            //Dictionary não aceita repetições então ele sobrescreve

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if(cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
