﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    class RelatorioSimples : Relatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
        }
    }
}
