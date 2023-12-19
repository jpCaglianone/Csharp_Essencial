
#region Modos_de_instanciação

//existem os 3 modos de instanciação abaixo (considerando uma classe com constructor padrão

ClassePessoa pessoa_1 = new ClassePessoa();
ClassePessoa pessoa_2 = new();
var pessoa_3 = new ClassePessoa();

#endregion

//abaixo, após o objeto pessoa_1 ter sido instanciado a partir da classe ClassePessoa, foram movidos valores para os atributos do objeto
//obs: esse modo não é uma boa prática

pessoa_1.altura = 1.89f;
pessoa_1.peso = 100;
pessoa_1.nome = "Felipe";

pessoa_1.apresentacao(); //invocando o método do objeto

pessoa_1.novoPeso(90.5f);






