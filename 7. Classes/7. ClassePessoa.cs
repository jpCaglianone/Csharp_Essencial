using System;

public class ClassePessoa //utiliza a chave class para definir uma classe
{
    //a chave public define que todos podem acessar o atributo, método ou classe, já o private determina que apenas aquela classe pode acessa-los
    public string nome;
    public int? idade;
    public float peso;
    public float altura;


    public float imc() //o método funciona como uma função, utilizando uma maneira de comunicação e aplicação de regra de negócio para a classe
    {
        return this.peso / (this.altura * this.altura); //a palavra reservada this faz referência ao atributo do próprio objeto que foi instanciado
    }

    public void apresentacao()
    {
        Console.WriteLine($"O usuário {this.nome} possui o imc igual a ${imc()}");
    }


    public void novoPeso (float peso) //método que define o novo peso e ainda exibe se o usuario ganhou, perdeu ou manteve o peso
    {
        string status;
        
        if (peso > this.peso)
        {
            status = " ganhou peso ";
        }
        else if (peso < this.peso)
        {
            status = " perdeu peso ";
        }
        else
        {
            status = " manteve o peso ";
        }

        this.peso = peso; //reatribuindo o atributo do objeto com o novo valor

        Console.WriteLine("O usuário " + this.nome + status + "!");
    }

}
