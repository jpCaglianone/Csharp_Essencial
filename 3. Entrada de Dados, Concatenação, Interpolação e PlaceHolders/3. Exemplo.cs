using System;

public class Exemplo
{
	public Exemplo()
	{

		Console.Write("Escreva seu nome: ");
		string nome = Console.ReadLine();

        Console.Write("Escreva sua idade: ");
        int idade = int.Parse(Console.ReadLine()); //aqui foi utilizada uma conversão, pois os dados recebidos do Console.ReadLine()
												   //vem em forma de string, e a variável é do tipo int. Os tipos de conversão serao
												   //abordados adiante. É necessário se atentar que o usuário pode inserir algum
												   //dado errado, como a idade por extenso, por exemplo, para isso serão abordados
												   //mais a frente os tratamentos de erro e algoritmos para evitar esses problemas.
												   //

		Console.WriteLine($"Olá {nome}. Legal saber que você tem {idade} anos!"); //método de interpolação

		string dados = nome + ";" + idade; //aqui ocorre uma conversão automática da variável idade para a concatenação

		Console.WriteLine(dados);

		

    }
}
