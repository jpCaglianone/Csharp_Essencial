using System;


namespace Atribuicao
{

    public class Exemplo
    {
        public Exemplo()
        {

            //atribuições simples
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;

            string y = "teste";
            bool z = false;

            Console.WriteLine("Pós-incremento: " + a++);
            Console.WriteLine("Variável pós-incrementada: " + a);
            Console.WriteLine("Pós-decremento: " + b--);
            Console.WriteLine("Variável pós-decrementada: " + b);
            Console.WriteLine("Pré-incremento: " + ++c);
            Console.WriteLine("Pré-decremento: " + --d);

            a += 10;
            Console.WriteLine("Soma o 10 a variável a :" + a);

            b -= 13;
            Console.WriteLine("Diminui o 13 a variável b :" + b);

            c *= 3;
            Console.WriteLine("Multiplica 3 a variável c :" + c);

            d /= 6;
            Console.WriteLine("Divide por 6 a variável d :" + d);

            int x = 3;   // O valor binário de x é 0000 0011

            x <<= 4;     // Desloca os bits de x 4 posições à esquerda
                         // O valor binário de x após o deslocamento será 0011 0000 (48 em decimal)

            Console.WriteLine("Deslocamento à esquerda: " + x);

            int w = 3;   // O valor binário de x é 0000 0011

            w >>= 1;     // Desloca os bits de x 4 posições à esquerda
                         // O valor binário de x após o deslocamento será 0000 0001 (1 em decimal)

            Console.WriteLine("Deslocamento à direita: " + w);


            int j = 12;      // O valor binário de x é 0000 1100
            int k = 7;       // O valor binário de y é 0000 0111

            j &= k;          // Realiza a operação AND bit a bit entre x e y, atribuindo o resultado a x
                             // O valor binário de x após a operação será 0000 0100 (4 em decimal)

            Console.WriteLine("Operação AND bit a bit: " + j);

            int m = 17;
            int n = 43;
            n %= m; //atribui a n o resto da divisão de n/m
            Console.WriteLine("Atribuição por resto: " + n);

            int e = 6;
            int f = 4;
            f ^= e;
            Console.WriteLine("Atribuição por operador xor: " + f);


        }
    }

}
