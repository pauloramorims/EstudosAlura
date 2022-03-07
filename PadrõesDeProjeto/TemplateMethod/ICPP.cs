using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => orcamento.Valor >= 500;
        protected override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.07;
        protected override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.05;
    }
}
