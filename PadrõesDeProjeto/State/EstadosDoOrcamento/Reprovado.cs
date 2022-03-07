using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.EstadosDoOrcamento
{
    public class Reprovado : IEstadosDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            // jah estou em aprovacao
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            // nao pode ser reprovado agora!
            throw new Exception("Orçamento está aprovado e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            // daqui posso ir para o estado de finalizado
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
