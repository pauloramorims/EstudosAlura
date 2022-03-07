using Design_Patterns;
using DesignPatterns;

//Quando devemos usar?
//Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos
//de outras classes envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que
//podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição
//desses comportamentos, bastando escolher no momento da instanciação, quais instancias
//serão utilizadas para realizar o trabalho.
Orcamento reforma = new Orcamento(500.0);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
reforma.Aprova(); // aprova nota!

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

reforma.Finaliza();

// reforma.AplicaDescontoExtra(); lancaria excecao, pois não pode dar desconto nesse estado
// reforma.Aprova(); lança exceção, pois não pode ir para aprovado