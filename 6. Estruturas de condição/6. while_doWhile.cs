 using System;
using System.ComponentModel.Design;

namespace while_doWhile
{  
	public class exemplo
	{
		public exemplo()
		{
			int numA = 10;
			while (numA > 0) // o loop irá ocorrer até essa condição ser atendida
			{
				Console.WriteLine(numA);
				--numA;				
			}


			int numB;
			do //o do executa a primeira repetição de loop e só depois analisa se a condição é atendida
			{
				Console.Write("Escreva um número maior que zero: ");
                numB = int.Parse(Console.ReadLine());

            }while (numB < 0);

			int op;
			do
			{
				op = Menu(); 
				if (op == 0)
				{
					Console.WriteLine("Adeus!");
					break; //instrução que força a saida do laço de repetição
				}

			}while (op < 0 || op > 3);


			Console.WriteLine("Digite a primeira dimensão da matriz: ");
			int primeiraDimensao = int.Parse(Console.ReadLine());

            Console.Write("Digite a segunda dimensão da matriz: ");
            int segundaDimensao = int.Parse(Console.ReadLine());

			matriz(primeiraDimensao, segundaDimensao);
			
		}

        private int Menu()
        {
            Console.WriteLine("Digite:\n" +
				"1 - cadastrar\n" +
				"2 - excluir\n" +
				"3 - consultar\n" +
				"0 - sair");
			int op = int.Parse(Console.ReadLine());
            return op;
        }


		private void matriz(int prim, int seg)
		{
			
		}

    }

}
 