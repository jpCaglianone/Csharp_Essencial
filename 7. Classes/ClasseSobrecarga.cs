using System;

public class ClasseSobrecarga
{
	public ClasseSobrecarga(){} //constructor padrão

	//private double a;
	//private double b;


	//teoricamente, não pode haver mais de um método com o mesmo nome na classe ou na herança, entretanto
	//é possível fazer uma sobrecarga, tendo o mesmo nome de métodos, alterando a quantidade de parâmetros, tipo de parâmetros
	// e/ou ordem de parâmetros


	//primeiro método somar
	public double Somar(double a, double b)
	{
		return a + b;
	}

	//sobrecargar por quantidade de parametros
    public double Somar(double a, double b, double c)
    {
        return a + b + c;
    }

	//sobrecarga por tipo de parametros
    public double Somar(double a, int b)
    {
        return a + b;
    }

	//sobrecarga por ordem de parametros (em relaçao ao anterior)
	public double Somar (int a, double b)
	{
		return a + b;
	}
}
