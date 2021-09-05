using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, Investimento investimento)
        {
            double resultado = investimento.Calcula(conta);
            resultado = conta.Saldo + resultado * 0.75;
            Console.WriteLine("Novo saldo: "+ resultado);
        }
    }
}
