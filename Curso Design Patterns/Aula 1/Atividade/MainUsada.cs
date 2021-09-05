/*

using System;

namespace Curso_Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Conservador conservador = new Conservador();
            Moderado moderado = new Moderado();
            Arrojado arrojado = new Arrojado();

            Conta conta = new();
            conta.Deposita(500.0);

            RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();

            // Calculando o Conservador
            Console.WriteLine("Conservador in: " + conta.Saldo);
            realizador.Realiza(conta, conservador);

            // Calculando o Moderado
            Console.WriteLine("\nConservador in: " + conta.Saldo);
            realizador.Realiza(conta, moderado); 

            // Calculando o Arrojado        
            Console.WriteLine("\nConservador in: " + conta.Saldo);
            realizador.Realiza(conta, arrojado);
        }   
    }
}
 
*/