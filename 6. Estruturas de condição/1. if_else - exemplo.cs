using System;

namespace if_else
{
	public class exemplo
	{
		public exemplo()
		{
			int a = 3;
			int b = 4;

			bool c = true;

			if (a < b)
			{
				Console.WriteLine("a menor que b");
			}
			else
			{
				Console.WriteLine("a maior que b");
			}


			if (!c)
			{
				Console.WriteLine("c é falso");
			}
			else
			{
				Console.WriteLine("c é verdadeiro");
			}

			Console.WriteLine("Escreva um número: ");
			int resultado = Convert.ToInt32(Console.ReadLine());
			if (resultado > 0)
			{
				Console.WriteLine("O número que você digitou é positivo!");
			}
			else if (resultado ==0)
			{
                Console.WriteLine("O número que você digitou é zero	!");
            }
			else
			{
                Console.WriteLine("O número que você digitou é negativo!");
            }


			float nota = 7f;
			char? conceito = null;

            if (nota >= 6) {
				if (nota <= 7.5)
				{
					conceito = 'C';	
				}
				else if (nota > 7.5 && nota <= 9)
				{
                    conceito = 'B';
                }
				else
				{
					conceito = 'A';
				}
			}
			else
			{
				conceito = 'D';
			}

			if (conceito != null) 
			{
				if (conceito == 'D') {Console.WriteLine("Aluno reprovado");}
				else { Console.WriteLine($"Aluno aprovado, seu conceito é {conceito}"); }
			}
			else { Console.WriteLine("Nenhum conceito foi atrelado!"); }

		}
	}
}
