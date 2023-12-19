using System;

namespace estruturaFor
{
	public class exemplo
	{
		public exemplo()
		{
            #region ex1 
            Console.WriteLine("************* Exemplo 1 ************");
            /*
                
                O for é uma instrução de repetição ou loop utilizada para executar um bloco de código várias vezes, 
            com base em uma condição. Ela é muito útil quando você sabe exatamente quantas vezes deseja repetir uma determinada ação.

                A estrutura básica do for é a seguinte:
               
                for (inicialização; condição; incremento)
                {
                    // Bloco de código a ser executado em cada iteração
                }
                Inicialização: Aqui é onde você inicializa uma variável de controle que será usada para controlar o 
            número de iterações do loop. Ela é geralmente uma variável inteira, mas também pode ser de outros tipos. 
            A inicialização é executada uma única vez, antes do loop começar.

                Condição: A condição é avaliada antes de cada iteração do loop. Se a condição for verdadeira, o bloco 
            de código dentro do loop é executado. Se a condição for falsa, o loop é encerrado.

                Incremento: O incremento define como a variável de controle é modificada após cada iteração do loop. 
            É a parte que controla como a variável avança para a próxima iteração. Geralmente, você aumenta ou diminui 
            o valor da variável de controle.

                Bloco de código: É o conjunto de instruções que você deseja que seja executado a cada iteração do loop. 
            Isso geralmente inclui as operações que você deseja realizar repetidamente.
             
             */

            for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}
            #endregion

            #region ex2
            Console.WriteLine("************* Exemplo 2 ************");
            for (int i = 20; i >= 0; i--)
			{
                Console.WriteLine(i);
            }
            #endregion

            #region ex3
            Console.WriteLine("************* Exemplo 3 ************");
            for (int i = 11; i >= 0; i--)
			{
				for(int j = 0; j <=7; j++)
				{
					Console.Write(j*i);
				}
			}
            #endregion

            #region ex4
            Console.WriteLine("************* Exemplo 2 ************");
            Console.Write("Insira o numero para sorteio: ");
            int x = int.Parse(Console.ReadLine());
        
            for (int i = 0; i <= 100; i++)
            {
               
                Random random = new Random();

                int numSort = random.Next(0, 11); //numero aleatorio entre 0 e 10
                Console.WriteLine(numSort);
                if (numSort == x)
                {
                    Console.WriteLine("Foram necessários " + i + 1 + " rodadas para o número ser sorteado.");
                    break; //quebra forçadamente o loop quando a condição for atendida
                }
                else
                {
                    if (i == 100)
                    {
                        Console.WriteLine("Mesmo com " + i + " rodadas, o número não foi sorteado!");
                    }
                }
               
            }
            #endregion

            #region ex5
            for (int i = 1; i <= 20; i++)
            {
                //este laço imprimirá apenas numeros pares
                if (i % 2 != 0)
                {
                    continue; //nesse ponto, quando o resto da divisão de 2 for diferente de 0,
                              //o laço entrará nessa linha. O continue fará com que o código
                              //volte para o for, executando o próximo passo e ignorando todo o resto
                }
                Console.WriteLine(i);

            }
            #endregion

            region ex6
            for (int i = 0, int j = 10; i - j != 0; i++, j--) //não é comum e talvez nem seja uma boa prática, porém, é possivel
                                                              //encaixar multiplas expressões
                                                    
            {
                Console.WriteLine("i: " + i + " j: " + j + " i - j: " + i-j);
            }
#endregion
        }
    }
}