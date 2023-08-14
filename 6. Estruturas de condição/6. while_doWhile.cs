 using System;

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
			

			
		}
	}
}
 