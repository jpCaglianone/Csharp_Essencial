using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 o tipo Dictionary<TKey, TValue> é uma coleção genérica que permite armazenar pares de chave-valor, onde cada chave é única. Ele é útil para casos 
em que você precisa de acesso rápido a valores com base em uma chave. Abaixo, vou explicar como criar, adicionar, acessar e manipular um Dictionary no .NET (C#).
da tambem pra armazenar objeto, como por exemplo Dictionary<Pessoa, int>
 */

namespace _9._Listas
{
    public class Dictionary
    {

        public static void ExemploDictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 35 }
        };

            ages["Diana"] = 40; // Adiciona um novo par chave-valor

            if (ages.ContainsKey("Alice"))
            {
                Console.WriteLine("Idade de Alice: " + ages["Alice"]);
            }

            ages.Remove("Bob"); // Remove Bob do dicionário

            foreach (var entry in ages)
            {
                Console.WriteLine($"Nome: {entry.Key}, Idade: {entry.Value}");
            }
        }
    }
}
