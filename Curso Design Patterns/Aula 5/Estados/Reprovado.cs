using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados nao funcionam");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja foi reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Nao é possivel Reprovado -> Reprovado direto");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
