using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor = 50.0 + (orcamento.Valor * 0.05);
            return valor;
        }
    }
}
