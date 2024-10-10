using System;

public class Parametros
{

	private string nome {  get; set; }
	private string email { get; set; }
	private int codigo { get; set; }

	public Parametros() {}

	public Parametros (string nome, string email, int codigo)
	{
		this.nome = nome;
		this.email = email;
		this.codigo = codigo;
	}

	public void imprimir() => Console.WriteLine(this.nome + " - " +  this.email + " - " + this.codigo);

	// aqui a passagem de parametro é opcional, tendo um valor default (padrao), chamado apelido padrao,
	// caso seja invocado e o argumento nao passado
	public string apelido (string apelido = "apelido padrao") => apelido;

    private string composicaoApelidoDefault()
	{
		return this.nome[1].ToString() + this.nome[this.nome.Length-1].ToString() + this.codigo%10;
	}

}
