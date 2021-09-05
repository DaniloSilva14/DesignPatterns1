using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public class Multiplicador : AcaoAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }
        public void Executa(NotaFiscal notaFiscal) {
            notaFiscal.ValorBruto = this.Fator * notaFiscal.ValorBruto;
            Console.WriteLine("mutliplicando fatorNotaFiscal");
            // Console.WriteLine("Valor Bruto: {0} Fator: {1} ", notaFiscal.ValorBruto, this.Fator);
        }
    }
}
