using System;
using System.Collections.Generic;

namespace Dictionary_e_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * DICTIONARY<TKEY, TVALUE>
            
            - É uma coleção de pares chave / valor
                - Não admite repetições do objeto chave
                - Os elementos são indexados pelo objeto chave (não possuem posição)
                - Acesso, inserção e remoção de elementos são rápidas
            - Uso comum: cookies, local storage, qualquer modelo chave-valor

            * DICTIONARY (Semelhante ao HashSet)
            
            - Armazenamento em tabela hash
            - Extremamente rápido: inserção, remoção e busca O(1)
            - A ordem dos elementos não é garantida

            * SORTEDDICTIONARY (Semelhante ao SortedSet)
            
            - Armazenamento em árvore
            - Rápido: inserção, remoção e busca O(log(n))
            - Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

            * ALGUNS MÉTODOS IMPORTANTES
            
            - dictionary[key] - Acessa o elemento pela chave informada
            - Add(key, value) - Adiciona elemento (exceção em caso de repetição)
            - Clear() - Esvazia a coleção
            - Count - Quantidade de elementos
            - ContainsKey(key) - Verifica se a data chave existe
            - ContainsValue(value) - Verifica se o dado valor existe
            - Remove(key) - Remove um elemento pela chave
            */

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {

                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
