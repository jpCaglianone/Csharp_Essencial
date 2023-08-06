using System;

namespace Logicos
{
	public class Exemplo
	{
		public Exemplo()
		{
            Console.WriteLine("**********************************************");
            Console.WriteLine("****************** lÓGICOS ******************");

            bool a = true;
			bool b = false;

			Console.WriteLine(a && b);
			Console.WriteLine(a || b);
			Console.WriteLine(!a);
		}
	}
}