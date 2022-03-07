//Essa a ideia: eu tenho uma interface e implemento estratégias embaixo dessa interface, passo essas estratégias para o resto do meu sistema e o meu sistema funciona de maneira genérica independente
//de imposto específico ou qualquer coisa específica que você esteja criando.
using Design_Patterns;
using DesignPatterns;


//IImposto iss = new ISS();
//IImposto icms = new ICMS();
//IImposto iccc = new ICCC();

//Orcamento orcamento = new Orcamento(5000.0);

//CalculadorDeImpostos calculador = new();

//calculador.RealizaCalculo(orcamento, icms);

Conta conta1 = new();
conta1.Deposita(500);

IInvestimento investimento = new Arrojado();
IInvestimento investimento2 = new Conservador();
IInvestimento investimento3 = new Moderado();


var realiza = new RealizadorDeInvestimentos();

realiza.Realiza(conta1, investimento);
realiza.Realiza(conta1, investimento2);
realiza.Realiza(conta1, investimento3);


