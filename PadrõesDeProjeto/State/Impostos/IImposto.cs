
namespace DesignPatterns
{
    public abstract class Imposto
    {
        protected readonly Imposto OutroImposto;
       
        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }
        public Imposto ( ) //construtor default para encerrar a chamada.
        {
            this.OutroImposto = null;
        }
        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
