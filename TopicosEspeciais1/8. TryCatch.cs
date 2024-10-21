using System;

//usado para tratamento de erros que podem ocorrer durante a
//execução do programa

public class TryCatch
{

    private int _numeroA;
    private int _numeroB;

    public TryCatch()
    { }

    public void setNumeroA(int numeroA)
    {
        this._numeroA = numeroA;
    }

    public void setNumeroB(int numeroB)
    {
        this._numeroB = numeroB;
    }

    public double? Dividir(int numeroA, int numeroB)
    {
        double? result = null;
        try
        {
            result = numeroA / numeroB;

        }
        catch (Exception e)
        {
            Console.WriteLine("Não foi possível realizar  operação: " + e);
        }
        finally
        {
            Console.WriteLine("fim do bloco try/catch");
            
        }
        return result;
    }


}
