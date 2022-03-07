
using Design_Patterns;
using DesignPatterns;

var orcamento = new Orcamento(600);

orcamento.AdicionaItem(new Item("LAPIS", 125));
orcamento.AdicionaItem(new Item("LAPIS", 250));
orcamento.AdicionaItem(new Item("LAPIS", 125));

Imposto imposto = new ISS( new ICMS());

Console.WriteLine(imposto.Calcula(orcamento));
Console.WriteLine(imposto.Calcula(orcamento));