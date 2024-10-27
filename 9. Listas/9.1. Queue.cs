using System;
using System.Collections.Generic;

// A idéia da fila é fazer o processamento FIFO (first-in, first-out),
// ou seja, o primeiro que entra é o primeiro que sai

namespace _9._Listas
{

    public class Queue
    {

        public static void fila()
        {
            // Cria uma fila para gerenciar tarefas
            Queue<string> filaTarefas = new Queue<string>();

            // Adiciona algumas tarefas na fila
            filaTarefas.Enqueue("Tarefa 1"); //o Enqueue adiciona na fila de forma ordenada
            filaTarefas.Enqueue("Tarefa 2"); 
            filaTarefas.Enqueue("Tarefa 3");

            Console.WriteLine("Tarefas na fila:");
            foreach (var tarefa in filaTarefas)
            {
                Console.WriteLine(tarefa);
            }

            // Processa as tarefas na ordem de chegada
            while (filaTarefas.Count > 0)
            {
                string tarefaAtual = filaTarefas.Dequeue(); //o Dequeue retira da fila na ordem
                                                            //que foi colocado

                Console.WriteLine($"\nProcessando: {tarefaAtual}");
            }

            Console.WriteLine("\nTodas as tarefas foram processadas.");
        }

    }



}
