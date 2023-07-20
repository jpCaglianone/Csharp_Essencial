using System;

public class Teoria
{
	public Teoria()
	{

        #region Entradas

        Console.ReadLine(); //essa função irá ler a próxima linha digitada pelo usuário, ou seja
							// ao chegar nessa linha de código, o programa irá pausar e esperar que o usuário 
							// digite algo. Somente quando o usuário apertar enter (quebra de linha)
							// o programa dará prosseguimento. 
							// o retorno desse método é tudo aquilo digitado pelo usuário

		Console.ReadKey(); //já esse comando recebe apenas um caracter, assim que o usuário apertar uma tecla,
						   // independente de qual seja, é lido e executado

		string teste = Console.ReadLine(); //nesse exemplo, tudo que é digitado pelo usuário é movido para a variável

		#endregion


		#region Concat_Interp_Place

		string t = " executado!";

		string a = "teste " + t; //é possivel mesclar um ou mais dados através da concatenação, mas é importante se atentar
								 //aos tipos de dados, pois se forem diferentes, é necessário passar por conversão
								 // exemplo: "11" + 22 dará erro
								 // pode ser executado diretamente no Console.WriteLine
								 //exemplo: Console.WriteLine("teste" + t);

		int x = 1;

		Console.WriteLine($"teste {x}"); //método pelo qual se invoca dentro da string passada para o console a própria variável

		float y = 31.2f;

		Console.WriteLine("{0} e {1} {2}", y, x, t); //invoca as variáveis pela ordem que são colocadas após na passagem de argumentos





        #endregion




    }
}
