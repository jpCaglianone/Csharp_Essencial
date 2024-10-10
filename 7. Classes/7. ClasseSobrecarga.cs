using System;

public class ClasseSobrecarga
{
	public ClasseSobrecarga(){} //constructor padrão

    // a sobrecarga pode ser adicionada tambem ao constructor

    public ClasseSobrecarga(double a, double b) //aqui, a sobrecarga no constructor pedindo dois parametros durante a
                                                //instanciação do objeto
    {
        this.Somar(a,b);
    }

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

    public void Dobrar(ref double a) // na passagem por referencia, a variavel que foi passada como argumento tem seu valor
                                     // alterado, aqui, nao foi necessario um return ou nada do tipo para afetar o valor da
                                     // variavel passada. Pode ser usado tambem o out ao inves do ref, possuindo algumas diferenças
    {
        a *=2 ;
    }

}
