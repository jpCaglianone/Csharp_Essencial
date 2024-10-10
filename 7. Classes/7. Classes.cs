﻿
#region Modos_de_instanciação

Console.WriteLine("----------------------------------- Modos de instanciação -----------------------------------");

//existem os 3 modos de instanciação abaixo (considerando uma classe com constructor padrão

ClassePessoa pessoa_1 = new ClassePessoa();
ClassePessoa pessoa_2 = new();
var pessoa_3 = new ClassePessoa();

#endregion

#region Exemplo_ClassePessoaConstructor

//abaixo, após o objeto pessoa_1 ter sido instanciado a partir da classe ClassePessoa, foram movidos valores para os atributos do objeto
//obs: esse modo não é uma boa prática

Console.WriteLine("----------------------------------- Constructor -----------------------------------");

pessoa_1.altura = 1.89f;
pessoa_1.peso = 100;
pessoa_1.nome = "Felipe";

pessoa_1.apresentacao(); //invocando o método do objeto

pessoa_1.novoPeso(90.5f);


ClassePessoaConstructor pessoa_4 = new("João"); //uso o constructor que solicita o nome como parametro, a IDE reconhece automaticamente
Console.WriteLine(pessoa_4.nome);

#endregion

#region Exemplo_ClasseSobrecarga

Console.WriteLine("----------------------------------- Modos de instanciação -----------------------------------");

double a = 1.1;
double b = 2.2;
double c = 3.3;
int x = 4;

ClasseSobrecarga classeSobrecarga = new();
Console.WriteLine(classeSobrecarga.Somar(a, b)); //invoca a primeira Somar
Console.WriteLine(classeSobrecarga.Somar(a, b, c)); //invoca a segundo Somar
Console.WriteLine(classeSobrecarga.Somar(x, a)); //invoca o quarto Somar

#endregion

#region PassagemPorReferencia

Console.WriteLine("----------------------------------- Passagem por referencia -----------------------------------");

Console.WriteLine("Bem antes da passagem por referencia " + b);
classeSobrecarga.Dobrar(ref b);
Console.WriteLine("Bem após a passagem por referencia " + b);

#endregion

#region Parametros

Console.WriteLine("----------------------------------- Parametros nomeados -----------------------------------");

string nome = "Joao";
string email = "joao@gmail.com";
int codigo = 261395432;

// com os argumentos nomeados, não é necessário passar exatamente na ordem que esta definida na classe ou metodo
// basta colocar o nome do parametro, seguido de dois ponto e o seu valor, como abaixo
Parametros parametro = new(codigo: codigo, nome: nome, email: email); //aqui a ordem definida era nome, email e codigo
//outro exemplo de instanciação
Parametros parametro1 = new(email: "aux@teste", codigo: 195128934, nome: "teste");
parametro.imprimir();
parametro1.imprimir();

Console.WriteLine("----------------------------------- Parametros opcionais -----------------------------------");

Console.WriteLine(parametro.apelido());

#endregion