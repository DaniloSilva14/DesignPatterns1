using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados nao funcionam");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja finalizado");
        }
    }
}
