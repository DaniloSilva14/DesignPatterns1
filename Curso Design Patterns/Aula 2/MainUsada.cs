/*
 using System;

namespace Curso_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("PANELA", 250.0));
            orcamento.AdicionaItem(new Item("FOGAO", 250.0));
            orcamento.AdicionaItem(new Item("XBOX", 250.0));
            orcamento.AdicionaItem(new Item("TV", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();
            
            // aqui e outro ex
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            Orcamento orcamento = new Orcamento(500.0);

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
            // termina aqui
        }
    }
}
*/