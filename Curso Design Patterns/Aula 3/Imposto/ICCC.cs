using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if(orcamento.Valor < 1000.0)
                return orcamento.Valor * 0.05;
            else if (1000.0 <= orcamento.Valor && orcamento.Valor <= 3000.0)
                return orcamento.Valor * 0.07;

            return (30.0 + (orcamento.Valor * 0.08));
        }
    }
}
