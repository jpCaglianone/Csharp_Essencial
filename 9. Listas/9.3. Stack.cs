using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//O Stack (ou pilha) é uma estrutura de dados linear onde os elementos são armazenados
//e acessados seguindo o princípio LIFO (Last In, First Out),
//ou seja, o último elemento adicionado é o primeiro a ser removido.
//Funciona como uma pilha de pratos: o último prato colocado no topo é o primeiro a ser retirado.

namespace _9._Listas
{
    public class Stack()
    {
        public static void exemploStack()
        {
            Stack<string> historicoNavegacao = new Stack<string>();

            // Adiciona páginas ao histórico
            historicoNavegacao.Push("Página 1 - Início");
            historicoNavegacao.Push("Página 2 - Produtos");
            historicoNavegacao.Push("Página 3 - Detalhe do Produto");

            // Mostra a página atual sem removê-la
            Console.WriteLine($"Página atual: {historicoNavegacao.Peek()}");

            Console.WriteLine("Voltando...");
            historicoNavegacao.Pop(); // Remove "Página 3 - Detalhe do Produto"

            // Mostra a nova página atual
            Console.WriteLine($"Página atual após voltar: {historicoNavegacao.Peek()}");

            // Adiciona uma nova página após "voltar"
            historicoNavegacao.Push("Página 4 - Contato");
            Console.WriteLine($"Nova página atual: {historicoNavegacao.Peek()}");
        }
    }

}

