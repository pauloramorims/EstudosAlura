using Design_Patterns;
using DesignPatterns;
using TemplateMethod;

var orcamento = new Orcamento(600);

orcamento.AdicionaItem(new Item("LAPIS", 125));
orcamento.AdicionaItem(new Item("LAPIS", 250));
orcamento.AdicionaItem(new Item("LAPIS", 125));

var imposto = new ICPP();
var imposto2 = new IKCV();
var ihit = new IHIT();

Console.WriteLine(imposto.Calcula(orcamento));
Console.WriteLine(imposto2.Calcula(orcamento));
Console.WriteLine(ihit.Calcula(orcamento));
