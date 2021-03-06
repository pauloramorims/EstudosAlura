using Design_Patterns;
using DesignPatterns;

//Quando devemos usar?
//Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos
//de outras classes envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que
//podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição
//desses comportamentos, bastando escolher no momento da instanciação, quais instancias
//serão utilizadas para realizar o trabalho.
var orcamento = new Orcamento(600);

orcamento.AdicionaItem(new Item("LAPIS", 125));
orcamento.AdicionaItem(new Item("LAPIS", 250));
orcamento.AdicionaItem(new Item("LAPIS", 125));

Imposto imposto = new ISS( new ICMS());

Console.WriteLine(imposto.Calcula(orcamento));
Console.WriteLine(imposto.Calcula(orcamento));