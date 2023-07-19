using System;
using System.Data;

public class exemplo
{
    public exemplo()
    {
        int x = 1;

        float y;
        y = 3.5f;

        double d = 23.32;
                                                                                                                                                                                                                                                                                                                                                                                
        decimal D = 322.3123m;

        string teste = "sua frase aqui";
        teste = "reescrevendo valor";

        #region Comparacao

        // é possivel fazer uma comparação e atribui-la a um boolean ou usa-la como saida
        bool comparacao = (d > 11.2); //se a variável d for maior que 11.2, a variavel comparacao receberá True, do contrário, reveberá false

        Console.WriteLine(comparacao); //imprimindo o conteúdo da variável e não a paralavra descricao (que deveria estar entre aspas se fosse o caso)\ 
                                       //também é possível eliminar a variável comparacao e colocar da seguinte maneira
                                       // Console.WriteLine(d > 11.2);


        #endregion


        #region Dynamic
        
        dynamic dinamico = true;

        dinamico = 1;
        Console.Write("Dinamico mudado:");
        Console.WriteLine(dinamico);

        dinamico = "abc";
        Console.Write("Dinamico mudado:");
        Console.WriteLine(dinamico);

        #endregion


        #region Datas

        DateTime dataAtual = DateTime.Now;
        Console.Write("A data atual é: ");
        Console.WriteLine(dataAtual); // esse struct busca a data atual tendo o PC como referência

        Console.Write("A hora atual é: ");
        Console.WriteLine(dataAtual.Hour); // esse struct busca a data atual tendo o PC como referência

        DateTime dataInventada = new DateTime(22,02,11,23,11,65);

        dataAtual.AddDays(1); //adiciona um dia a data
        dataAtual.AddHours(1); //adiciona uma hora a data
        dataAtual.AddMonths(2); //adiciona dois meses a data
        dataAtual.AddYears(4); //adiciona quatro anos a data
        dataAtual.AddMinutes(1); //adiciona um minuti a data
        dataAtual.AddSeconds(1);
        dataAtual.AddMilliseconds(1);

        Console.WriteLine(dataAtual.DayOfWeek); //Retorna o nome do dia da semana
        Console.WriteLine(dataAtual.DayOfYear);


        #endregion


    }
}
