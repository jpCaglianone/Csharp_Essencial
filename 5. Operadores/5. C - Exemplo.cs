using System;

namespace Relacionais
{

	public class Exemplo
	{
		public Exemplo()
		{

            Console.WriteLine("**********************************************");
            Console.WriteLine("*************** RELACIONAIS ******************");

            int num1 = 0;
			int num2 = 2;

			bool a = num1 < num2;
			bool b = num2 < num1;
			bool c = 13 > num1;
			bool d = num2 == 2;
			bool e = num1 != 0;

			Console.WriteLine(a + " - " + b + " - " + c + " - " + d + " - " + e);

		}
	}
}