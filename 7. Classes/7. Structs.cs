using System;
//struct é alocado na stack, enquanto uma classe é alocada no heap e
//gerenciada pelo garbage collector. Isso torna os structs mais eficientes
//em termos de desempenho para tipos pequenos e imutáveis,
//onde você quer evitar a sobrecarga de alocação de memória no heap.
public struct Structs
{ 
    public string nome {  get; set; }
    public int? codigo { get; set; }

    public Structs (string nome, int? codigo)
    {
        this.nome = nome;
        this.codigo = codigo;
    }
}