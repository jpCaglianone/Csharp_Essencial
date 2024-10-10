using System;


// métodos estáticos são métodos que não dependem da instanciação de um
// objeto pela classe para serem usados
// Console.WriteLine, por exemplo, o método WriteLine da classe Console
// é usado, porém, não é necessário uma instância prévia de um objeto do
// tipo Console

public class Estaticos
{


	//é possivel fazer o mesmo com parametros
	public static int num;
	public Estaticos(){}


	// so pode ter um unico construtor statico,
	// nao usa modificadores de acesso e nao tem parametros,
	// o usuario nao tem controle sobre quando é executado, 
	// usado para inicializar os campos estaticos
	static Estaticos()
	{
		Console.WriteLine("Executanto o construtor estatico");
	}

	public static string criarApelido(string nome, int codigo)
	{
		return nome[0].ToString() + nome[nome.Length-1].ToString() + codigo%10;
	}
}
