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

            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImposto calculador = new CalculadorDeImposto();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizaCalculo(orcamento, icms);

            // Calculando o ICCC        
            calculador.RealizaCalculo(orcamento, iccc);
        }
    }
}
 
*/