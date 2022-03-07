using Design_Patterns;
using DesignPatterns;

//Quando devemos usar?
//A principal situação que faz emergir o Design Pattern State é a necessidade de implementação
//de uma máquina de estados. Geralmente, o controle das possíveis transições são vários e
//complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o controle
//dos estados simples e organizados através da criação de classes que representem cada estado e
//saiba controlar as transições.

Orcamento reforma = new Orcamento(500.0);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
reforma.Aprova(); // aprova nota!

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

reforma.Finaliza();

// reforma.AplicaDescontoExtra(); lancaria excecao, pois não pode dar desconto nesse estado
// reforma.Aprova(); lança exceção, pois não pode ir para aprovado