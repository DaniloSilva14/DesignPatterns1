using System;
using System.Collections.Generic;

namespace Curso_Design_Patterns
{
    class Program
    {
        public static void Main(String[] args)
        {
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new EnviadorDeEmail());
            builder.AdicionaAcao(new SalvadorBD());
            builder.AdicionaAcao(new EnviadorDeSms());
            builder.AdicionaAcao(new Impressora());
            builder.AdicionaAcao(new Multiplicador(3));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                                .ComCnpj("123.456.789/0001-10")
                                .ComItem(new ItemDaNota("item 1", 100.0))
                                .ComItem(new ItemDaNota("item 2", 200.0))
                                .ComItem(new ItemDaNota("item 3", 300.0))
                                .ComObservacoes("entregar notaFiscal pessoalmente")
                                .Constroi();
            Console.ReadKey();
        }
    }
}