using System;

public class ClassePessoaConstructor
{

    //construtor é a regra imposta para criar a classe, ou seja, se precisa de parâmetros ou não, obrigando essa passagem na instanciação do objeto

    public string nome;
    public int? idade;
    public float peso;
    public float altura;


    // construtor padrão, possui o mesmo nome da classe e é vazio -> public ClassePessoaConstructor()
    public ClassePessoaConstructor(string nome)
    {
        Console.WriteLine("Construtor criado apenas com nome ");
        this.nome = nome; //atribui o atributo do objeto que está sendo instanciado com o nome que foi passado por parâmetro
    }
    public ClassePessoaConstructor(string nome, int idade, float altura, float peso) : this(nome) //esse this chama o constructor que possui apenas o parametro do
                                                                                                  //this, ou seja, chama um constructor dentro de outro
    {
        this.nome = nome;
        this.idade = idade;
        this.peso = peso;
        this.altura = altura;   
           
    }

   

}
