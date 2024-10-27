using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static _9._Listas.HashSet;


// O HashSet é uma estrutura de dados que armazena elementos de forma não ordenada
// e sem duplicação. Ele é eficiente para verificar rapidamente a existência de um elemento e
// é muito útil quando queremos armazenar apenas valores únicos, sem repetir nenhum deles.


namespace _9._Listas
{
    public class HashSet()
    {

        HashSet<Produto> produtos = new HashSet<Produto>();

        public static void fila1()
        {
            HashSet<int> userIds = new HashSet<int>();

            int[] idsParaAdicionar = { 101, 102, 103, 104, 105, 101 }; // 101 está duplicado

            Console.WriteLine("Tentando adicionar IDs:");

            foreach (var id in idsParaAdicionar)
            {
                if (userIds.Add(id))
                {
                    Console.WriteLine($"ID {id} adicionado com sucesso.");
                }
                else
                {
                    Console.WriteLine($"ID {id} já existe no HashSet.");
                }
            }


            Console.WriteLine("\nIDs únicos no sistema:");
            foreach (var id in userIds)
            {
                Console.WriteLine(id);
            }
        }

        public static void fila2()
        {

            Produto produto0 = new Produto()
            {
                Codigo = 1,
                Nome = "caneca"
            };

            Produto produto1 = new Produto()
            {
                Codigo = 1,
                Nome = "prato"
            };

            Produto produto2 = new Produto()
            {
                Codigo = 2,
                Nome = "faca"
            };

            HashSet teste = new HashSet();

            teste.adicionarProduto(produto1);
            teste.adicionarProduto(produto0);
            teste.adicionarProduto(produto2);
        }

        public void adicionarProduto(Produto produto)
        {
            if (produtos.Add(produto))
            {
                Console.WriteLine($"Produto '{produto.Nome}' adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto com código {produto.Codigo} já existe no inventário.");
            }
        }

        public class Produto
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }

            public override int GetHashCode()
            {
                return this.Codigo.GetHashCode();
            }

            public override bool Equals(Object prod)
            {

                Produto outroProduto = (Produto)prod;
                return Codigo == outroProduto.Codigo;
            }


        }

    }
}
