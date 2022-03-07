using Design_Patterns;
using DesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Crie o imposto IHIT, que tem a seguinte regra: caso existam 2 ítens com o mesmo nome,
//o imposto deve ser de 13% mais R$100,00.
//Caso contrário, o valor do imposto deverá ser (1% * o número de ítens no orçamento).
namespace TemplateMethod
{
    internal class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento) => Ha2ItensComMesmoNome(orcamento);

        protected override double MaximaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.13 + 100;

        protected override double MinimaTaxacao(Orcamento orcamento) => orcamento.Valor * 0.01 * orcamento.Itens.Count;

        private bool Ha2ItensComMesmoNome(Orcamento orcamento)
        {
            var temp = new List<string>();
            // adiciona os itens em uma lista temporária, caso já exista o item, o método é encerrado 
            foreach (Item item in orcamento.Itens)
            {
                if (temp.Contains(item.Nome))
                {
                    return true;
                }
                else
                {
                    temp.Add(item.Nome);
                }
            }
            return false;
        }
    }
}
