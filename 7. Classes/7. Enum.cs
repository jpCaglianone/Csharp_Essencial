using System;

enum DiasSemana
{
    domingo,
    segunda,
    terça,
    quarta,
    quinta,
    sexta,
    sabado
}


public class Enum
{
    public Enum()
    {
        Console.WriteLine(DiasSemana.quarta);
        Console.WriteLine((int)DiasSemana.quarta);
    }

}
