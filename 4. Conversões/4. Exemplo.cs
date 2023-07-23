using System;

public class Exemplo
{
	public Exemplo()
	{

		int numA = 22;
		double numB = (numA * 1783413) / 3.2;
		Console.WriteLine("numB: " + numB);

		uint numC = (uint)numB; //perda de precisão pois foi convertido uma variável double para int;
        Console.WriteLine(numC);

		Console.Write("Escreva um número: ");
		float numD = float.Parse(Console.ReadLine());

        Console.Write("Escreva outro número: ");
        float numE = Convert.ToSingle(Console.ReadLine());

        Console.Write("Escreva mais um número: ");
        int numF = int.Parse(Console.ReadLine());

        int numeroInt = 42;
        short numeroShort = Convert.ToInt16(numeroInt); // Convertendo int para short (Int16)

        long numeroLong = 1234567890;
        int numInt = Convert.ToInt32(numeroLong); // Convertendo long para int (Int32)

        double numeroDouble = 3.14159;
        long numLong = Convert.ToInt64(numeroDouble); //

        string s1 = numA.ToString();
        string s2 = numB.ToString();
        string s3 = numC.ToString();
        string s4 = numD.ToString();

    }
}
