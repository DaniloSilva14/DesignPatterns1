/*
using System;
using System.Collections.Generic;

namespace Curso_Design_Patterns
{
    class Program
    {
        public static void Main(String[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder()
                              .ParaEmpresa("Caelum")
                              .ComCnpj("123.456.789/0001-10")
                              .ComItem(new ItemDaNota("item 1", 100.0))
                              .ComItem(new ItemDaNota("item 2", 200.0))
                              .ComItem(new ItemDaNota("item 3", 300.0))
                              .ComObservacoes("entregar nf pessoalmente")
                              .NaData(new DateTime().Date);

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
*/