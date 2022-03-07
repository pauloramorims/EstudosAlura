//Essa a ideia: eu tenho uma interface e implemento estratégias embaixo dessa interface, passo essas estratégias para o resto do meu sistema e o meu sistema funciona de maneira genérica independente
//de imposto específico ou qualquer coisa específica que você esteja criando.
using Chain_of_Responsability.Descontos;
using Design_Patterns;
using DesignPatterns;

CalculadorDeDescontos calculador = new CalculadorDeDescontos();

Orcamento orcamento = new Orcamento(500.0);

orcamento.AdicionaItem(new Item("CANETA", 250.0));
orcamento.AdicionaItem(new Item("LAPIS", 250.0));

double desconto = calculador.Calcula(orcamento);

Console.WriteLine(desconto);

