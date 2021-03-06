using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000.00)
                return orcamento.Valor * 0.05;

            else if (orcamento.Valor >= 1000.00 || orcamento.Valor <= 3000.00)
                return orcamento.Valor * 0.07;

            else if (orcamento.Valor > 3000.00)
                return orcamento.Valor * 0.08 + 30;

            else
                return 0;
        }
    }
}
