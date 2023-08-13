using System;

namespace gotolabel
{
    public class exemplo
    {
        public exemplo()
        {
        inicio:
            Console.Write("Digite um número positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.WriteLine("O número deve ser positivo.");
                goto inicio;
            }
            else
            {
                Console.WriteLine("Você digitou um número válido: " + numero);
            }
        }
    }
}
