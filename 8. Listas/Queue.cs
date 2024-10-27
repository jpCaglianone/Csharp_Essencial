using System;
using System.Collections.Generic;

namespace _8._Listas
{

    public class Queue
    {


        public static void fila()
        {
            // Cria uma fila para gerenciar tarefas
            Queue<string> filaTarefas = new Queue<string>();

            // Adiciona algumas tarefas na fila
            filaTarefas.Enqueue("Tarefa 1");
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
                string tarefaAtual = filaTarefas.Dequeue();
                Console.WriteLine($"\nProcessando: {tarefaAtual}");
            }

            Console.WriteLine("\nTodas as tarefas foram processadas.");
        }

    }



}
