using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<String> noOrcamento = new List<String>();

            foreach (Item item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                    return true;
                else
                    noOrcamento.Add(item.Nome);
            }
            return false;
        }
        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return 100.0 + orcamento.Valor * 0.13;
        }
        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.Count * 0.01;
        }
    }
}
