using System;

namespace Aritmeticos

{
	public class Exemplo
	{
		public Exemplo()
		{
            float x = 13.2f;
            float y = 54.1f;


            // Biblioteca Math
            // Math.PI = representa o número pi
            // Math.E = representa a base e do logaritmo natural
            // Cos(x) = obtém o cosseno de x
            // Sin(x) = obtém o seno de x
            // Tan(x) = obtém a tangente de x
            // Sqrt(x) = obtém a raiz quadrada de x
            // Pow(x,y) = obtém a potência de x elevado a y
            // Abs(x) = obtém o valor absoluto de x
            // Max(x,y) = obtém o maior valor entre dois números
            // Min(x,y) = obtém o menor valor entre dois números
            // Log10(x) = calcula o logaritmo de x na base 10
            // Log(x) = calcula o logaritmo de x na base e
            // Exp(x) = retorna o exponencial (e elevado a x)

            Console.WriteLine($"A soma entre {x} e {y} é : {x + y}");
            Console.WriteLine($"A subtração entre {x} e {y} é : {x - y}");
            Console.WriteLine($"A multiplicaçao entre {x} e {y} é : {x * y}");
            Console.WriteLine($"A divisão entre {x} e {y} é : {x / y}");
            Console.WriteLine($"O módulo entre {x} e {y} é : {x % y}");

            Console.WriteLine($"O cosseno de 85 {Math.Cos(85)}");
            Console.WriteLine($"O seno de {x} é {Math.Cos(x)}");
            Console.WriteLine($"A tangente de {y} é {Math.Tan(y)}");

            Console.WriteLine($"A raiz quadrade de 9 é {Math.Sqrt(9)}");
            Console.WriteLine($"{x} elevado a {y} é : " + Math.Pow(x,y));


            Console.WriteLine($"A soma entre {x} e {y} é : {x + y}");
            Console.WriteLine($"A soma entre {x} e {y} é : {x + y}");
            Console.WriteLine($"A soma entre {x} e {y} é : {x + y}");
            Console.WriteLine($"A soma entre {x} e {y} é : {x + y}");
        }

      
    }

}
