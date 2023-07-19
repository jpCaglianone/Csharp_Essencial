using System;

namespace SaidaDeDados
{
    class SaidaDeDados
    {
        static void Main(string[] args)
        {


            //OBS: toda linha de comando deve ser terminada com ponto e vírgula ";"

            // Os comentários de linha são iniciados com // e os comentários de bloco são colocados entre /* ... */, onde as reticências serão tudo aquilo que será comentado

            Console.WriteLine("Hello World!");
            /*
                o comando Console.WriteLine é responsável pela saída de dados, de modo a "imprimir"no console
               (tela de saida) tudo aquilo que estiver dentro dos parênteses 
            */

            // exemplo 1
            Console.WriteLine(123);

            // exemplo 2
            Console.WriteLine(12 + 42 - 90 * (-3));


            Console.Write("Não pula linha"); //semelhante ao WriteLine, porém, não há quebra de linha

            Thread.Sleep(2500); //para o sistema pela quantidade de milissegundo dentro do parenteses, no caso, 2500 milissegundos


        }
    }
}