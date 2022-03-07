

using Design_Patterns;
using State.EstadosDoOrcamento;

namespace DesignPatterns;

public class Orcamento
{
    public double Valor { get; set; }
    public IEstadosDeUmOrcamento EstadoAtual { get; set; }
    public IList<Item> Itens { get; private set; }

    public Orcamento(double valor)
    {
        Valor = valor;
        Itens = new List<Item>();
        EstadoAtual = new EmAprovacao();
    }

    public void AplicaDescontoExtra()
    {
        EstadoAtual.AplicaDescontoExtra(this);
    }

    public void Aprova()
    {
        EstadoAtual.Aprova(this);
    }

    public void Reprova()
    {
        EstadoAtual.Reprova(this);
    }

    public void Finaliza()
    {
        EstadoAtual.Finaliza(this);
    }

    public void AdicionaItem(Item item) 
    {
        Itens.Add(item);
    }
}
