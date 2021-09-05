using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public abstract class Imposto
    {
        private readonly Imposto OutroImposto;

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        // construtor default
        public Imposto()
        {
            this.OutroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            if (OutroImposto == null) 
                return 0;
            
            return OutroImposto.Calcula(orcamento);
        }
    }
}
