using Design_Patterns;
using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento);
        
        protected override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.10;
        
        protected override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.06;
       
        private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            // retorna verdadeiro caso algum item seja maior que 100 reais
            foreach(Item item in orcamento.Itens)
            {
                if(item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
