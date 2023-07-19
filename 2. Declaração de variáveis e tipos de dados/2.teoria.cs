using System;

public class Teoria  
{
	public Teoria()
	{
        /*
            a declaração de uma variável é feita pela seguinte estrutura:
           tipo_dado nome_variavel 
           opcionalmente, podemos atribuir ou não valores
           é possivel também declarar uma variável com a palavra reservada "var"
           onde obrigatoriamente precisa de atribuiçao de um valor. Através desse valor atribuido, 
           será definido o tipo correspondemte de forma automatica pela IDE
            */

        var variavel = "Teste";
        /* variavel = 132; se esse linha de código não fosse um comentário, daria erro, pois
            anteriormente foi atribuido um valor a variável que fez ela adquirir um tipo de dado
            diferente do novo que está sendo atribuido
        */

        int numero1; //declaração de uma variável do tipo número inteiro com sinal de 32 bits.
        double numero2;
        long numero3; // Inteiro com sinal de 64 bits.
        float numero4; // Número de ponto flutuante de precisão simples com sinal de 32 bits. Ao atribuir um valor, precisa ser colocado a letra f. Exemplo float x = 12.32f;
        double numero5; // Número de ponto flutuante de precisão dupla com sinal de 64 bits.
        decimal numero6; // decimal de alta precisão com sinal de 128 bits.   Ao atribuir um valor, precisa ser colocado a letra m. Exemplo decimal y = 12.32m;
        short numero7; // Inteiro com sinal de 16 bits.
        byte numero8; // Inteiro sem sinal de 8 bits.
        sbyte numero9; // Inteiro com sinal de 8 bits.
        ushort numero10;// Inteiro sem sinal de 16 bits.
        uint numero11; // Inteiro sem sinal de 32 bits.
        ulong numero12; // Inteiro sem sinal de 64 bits.

        bool verdadeiro_falso; // Valor booleano que pode ser verdadeiro ou falso.
        char caractere; //Caractere Unicode de 16 bits.
        string palavra;// Sequência de caracteres Unicode.


        object objeto; // A classe base de todos os tipos em C#. Pode armazenar qualquer tipo de valor.
        dynamic dinamico; // Permite que as variáveis tenham seu tipo verificado em tempo de execução.


        //void : Indica a ausência de tipo ou valor.Geralmente usado em declarações de método para indicar que o método não retorna um valor.


        // o enuma traz uma seleção de constantes programadas, como uma espécie de objeto, de modo
        // a atribuir o valor de cada constante automaticamente, sendo, no exemplo abaixo, Segunda = 0,
        // Terca = 1 e assim por diante, como se fossem opções pré-definidas
        //   enum DiasDaSemana
        //{
        //    Segunda,
        //    Terca,
        //    Quarta,
        //    Quinta,
        //    Sexta,
        //    Sabado,
        //    Domingo
        //} 


        const int A = 123;

        Console.WriteLine("Teoria executada!");

    }
}
