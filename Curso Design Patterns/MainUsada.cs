/*
using System;

namespace Curso_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Imposto iccc = new ICCC();
            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();
            Imposto ihit = new IHIT();

            CalculadorDeImposto calculador = new CalculadorDeImposto();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("PANELA", 250.0));
            orcamento.AdicionaItem(new Item("FOGAO", 250.0));
            orcamento.AdicionaItem(new Item("XBOX", 250.0));
            orcamento.AdicionaItem(new Item("TV", 250.0));

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

            // Calculando o ICCC        
            calculador.RealizaCalculo(orcamento, iccc);

            // Calculando o ICPP        
            calculador.RealizaCalculo(orcamento, icpp);

            // Calculando o IKCV        
            calculador.RealizaCalculo(orcamento, ikcv);

            // Calculando o IHIT        
            calculador.RealizaCalculo(orcamento, ihit);

            Console.ReadKey();
        }
    }
}
 
*/