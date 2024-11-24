using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._Listas
{
    public class Matriz
    { 
        public static void exemploArray()
        {
    
            //declaração de array
            //tipo, [], nome variavel, =, new tipo, quantidade de elementos no array ou elementos de fato
            //quantidade declarada
            int[] arr = new int[10];
            //elementos de fato
            String[] nomes = new String[] {"joao","bernardo","natalia"};
            //sem quantidade declarada
            Double[] doubles = new Double[] { };

            //acessando valores = atraves do indice que é um nummero, começando do zero, ou seja,
            //se quiser acessar o segundo elemento é necessario usar o indice 1. Exemplo : array[1]
            //para atribuir ou alterar valores, pode-se usar o mesmo processo

            Console.WriteLine(nomes[1]);
            nomes[1] = "Alex";
            Console.WriteLine(nomes[1]);

 
        }

        public static void metodosArray()
        {

            string[] arr = new string[] { "z", "b", "c", "d", "a", "x", "f", "k", "h", "e", "p" };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //indica o tamanho do array - Array.Lenght

            Console.WriteLine(arr.Length);

            //metodo para ordenar um array - Array.Sort()
            Array.Sort(arr);
            foreach (var item in arr)
            {
             Console.Write(item);
            }

            Console.WriteLine(".");

            //método para inverter a ordem atual dos elementos de um array - Array.Reverse()
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine(".");

            //para saber o indice de algum elemento(valor), caso o elemento não seja encontrado,
            //é retornado o valor -1 - Array.IndexOf()
            Console.WriteLine(Array.IndexOf(arr, "c"));

            //copia o array para outra array de destino com a quantidade de elementos - Array.Copy()
            string[] copia = new string[5];
            Array.Copy(arr, copia, 5); //define quantos elementos serão copiados, começando do primeiro
            foreach (var item in copia)
            {
                Console.Write(item);
            }

            //cria uma copia direta e superficial, clonada - Array.Clone()
            string[] cloneArr = (string[])arr.Clone();

            //redefinir o tamanho do array. Caso a nova definiçao seja maior, serão colocados valores
            //padrão para as novas posições, caso seja menor, o valor anterior e perdido - Array.Resize()
            Array.Resize(ref cloneArr, 35);
            foreach (var item in cloneArr)
            {
                Console.Write(item);
            }
            Console.WriteLine(".");
            Console.WriteLine(cloneArr.Length);
            Array.Resize(ref cloneArr, 2);
            foreach (var item in cloneArr)
            {
                Console.Write(item);
            }
            Console.WriteLine(".");
            Console.WriteLine(cloneArr.Length);

            //redefine uma faixa de valores do array para valores padrao - Array.Clear()
            //se o unico argumento passado for o nome do array, irá redefinir todos os 
            //elementos, se nao, pode ser passado apenas a faixa, sendo o primeiro valor o
            //indice e o segundo a quantidade de elementos a partir do indice
            Array.Clear(arr, 1, 3);
            foreach (var item in arr)
            {
                Console.Write(item);
            }

            Console.WriteLine("");

            //percorre todo o array pra ver se um elemento satisfaz uma determinada
            //condição. Array.Exists()
            Console.WriteLine(Array.Exists(arr, x => x == "n"));

            //retorna o primeiro elemento que satisfaça a condição determinada
            //Array.Find()
            Console.WriteLine(Array.Find(arr2, x => x > 3));

            //retorna todos os elementos que satisfaça a condição determinada
            //em forma de objeto - Array.FindAll()
            var a = Array.FindAll(arr2, x => x > 3);
            foreach( var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine("");

            //reforna o indice do elemento que satisfaça a condição determinada
            //Array.FindIndex()
            Console.WriteLine(Array.FindIndex(arr2, x => x >= 7 ));

            //fatia o array e cria uma copia com essa fatia, semelhante
            //ao slice, onde se passa o indice de onde deseja começar e a
            //quantidade de elementos como parametros - Array.Segment
            ArraySegment<int> segment = new ArraySegment<int>(arr2, 2, 5);
            foreach (var item in segment)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }

        public static void exemploArray2()
        {
            string[] arr = new string[] {"a","b","c", "d", "e", "f", "g", "h" };
        }
    }
}
