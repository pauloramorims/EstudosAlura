using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

class NotaFiscalBuilder
{
    private string RazaoSocial;
    private string Cnpj;
    public string Observacoes;
    private double ValorTotal;
    private double Impostos;
    private IList<ItemDaNota> TodosItens = new List<ItemDaNota>();
    public DateTime Data { get; set; }

    public NotaFiscal Constroi()
    {
        return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, TodosItens, Observacoes);
    }

    public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
    {
        this.RazaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilder ComCnpj(string cnpj)
    {
        this.Cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder ComObservacoes(string observacoes)
    {
        Observacoes = observacoes;
        return this;
    }

    public NotaFiscalBuilder NaDataAtual()
    {
        Data = DateTime.Now;
        return this;
    }

    public NotaFiscalBuilder ComItem(ItemDaNota item)
    {
        TodosItens.Add(item);
        ValorTotal += item.Valor;
        Impostos += item.Valor * 0.05;

        return this;
    }
}
