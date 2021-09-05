/*
using System;
using System.Collections.Generic;

namespace Curso_Design_Patterns
{
    class Program
    {
        static void Main(String[] args)
        {
            Imposto impostoComplexo = new ImpostoMuitoAlto(new ICMS(new ISS()));
            // Imposto impostoComplexo = new ImpostoMuitoAlto(new ICPP(new ISS()));

            Orcamento orcamento = new Orcamento(500.0);

            double valor = impostoComplexo.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
} 
*/