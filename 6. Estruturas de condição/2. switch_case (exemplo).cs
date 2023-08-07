using System;

namespace switch_case 
{ 
public class exemplo
	{
		public exemplo()
		{
			string msgPadrao = "Este mês tem ";
			string mes31 = "31 dias!";
			string mes30 = "30 dias!";
			string mesFev = "28 ou 29 dias!";

			Console.Write("Escreva um mês: ");
			string mes = Console.ReadLine();

			switch (mes.ToLower())
			{
				case "janeiro":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

				case "fevereiro":
                    Console.WriteLine(msgPadrao + mesFev);
                    break;

                case "março":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

                case "abril":
                    Console.WriteLine(msgPadrao + mes30);
                    break;

                case "maio":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

                case "junho":
                    Console.WriteLine(msgPadrao + mes30);
                    break;

                case "julho":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

                case "agosto":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

                case "setembro":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

                case "outubro":
                    Console.WriteLine(msgPadrao + mes30);
                    break;

                case "novembro":
                    Console.WriteLine(msgPadrao + mes30);
                    break;

                case "dezembro":
                    Console.WriteLine(msgPadrao + mes31);
                    break;

                default:
                    Console.WriteLine("Mês inválido");
                    break;  
            }
		}
	}
}
