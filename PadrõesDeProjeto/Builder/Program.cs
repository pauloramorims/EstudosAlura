using Builder;

//Quando devemos usar?

NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("Caelum")     //Method chaining
                       .ComCnpj("123.456.789/0001-10")
                       .ComItem(new ItemDaNota("item 1", 100.0))
                       .ComItem(new ItemDaNota("item 2", 200.0))
                       .ComItem(new ItemDaNota("item 3", 300.0))
                       .ComObservacoes("entregar nf pessoalmente")
                       .NaDataAtual()
                       .Constroi();

Console.WriteLine(nf.ToString());
Console.WriteLine(nf.Observacoes);

