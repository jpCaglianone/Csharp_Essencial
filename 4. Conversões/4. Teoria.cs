using System;

public class Teoria
{
	public Teoria()
	{


		//Conversão Implícita: Essa conversão ocorre automaticamente quando não há perda de dados e não é necessário nenhum operador de conversão explícito.
		int numInteiro = 40;
		long numConvert = numInteiro; //não é necessário nenhum operador especial e a conversão só acontece pois um numero do tipo int possui menos bits que
									  //um número do tipo long, logo, int "cabe" dentro de long

		//Conversão Explícita (Casting): Essa conversão é feita manualmente usando um operador de casting.
		//Pode haver perda de dados se o valor estiver fora do intervalo do tipo de destino.

		int numA = (int)numConvert; //nesse caso, a conversão ocorre, porém, se o tipo convertido possuir menos bits que o tipo que ele recebe pode
                                    //haver perda de dados

        //Conversão com métodos Parse e TryParse: Essa conversão é usada para converter tipos primitivos a partir de uma representação de string.
        //Os métodos Parse e TryParse estão disponíveis para tipos numéricos, DateTime, Boolean, etc.

        string texto = "42";
        int numero = int.Parse(texto); // Conversão de string para int usando Parse


        //Conversão com métodos Convert: A classe Convert fornece métodos estáticos para converter diversos tipos de dados entre si,
        //incluindo tipos primitivos e tipos comuns.

        texto = "3.14";
        double numeroDouble = Convert.ToDouble(texto); // Conversão de string para double usando Convert

        float a = 1.32f;
        double numd = Convert.ToDouble(a); //conversão de float para double utilizando metodo Convert

        //Conversão de tipos de referência: Para converter tipos de referência, como classes e interfaces,
        //você pode usar conversões implícitas(quando há herança ou interfaces implementadas) ou conversões explícitas(casting).

        object obj1 = "Olá, mundo!";
        string text = obj1 as string; // Conversão de tipo de referência com "as" (conversão segura)
        /*
        Convert.ToInt16:
        O método Convert.ToInt16 é usado para converter valores de outros tipos numéricos ou strings em um inteiro de 16 bits, também conhecido como short em C#. Esse tipo tem um tamanho de 2 bytes e pode armazenar valores inteiros na faixa de -32,768 a 32,767.
        
        Convert.ToInt32:
        O método Convert.ToInt32 é usado para converter valores de outros tipos numéricos ou strings em um inteiro de 32 bits, também conhecido como int em C#. Esse tipo tem um tamanho de 4 bytes e pode armazenar valores inteiros na faixa de -2,147,483,648 a 2,147,483,647.

        Convert.ToInt64:
        O método Convert.ToInt64 é usado para converter valores de outros tipos numéricos ou strings em um inteiro de 64 bits, também conhecido como long em C#. Esse tipo tem um tamanho de 8 bytes e pode armazenar valores inteiros na faixa de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807.
       
*/
        //Conversão ToString()
        string y = numd.ToString();



    }
}
