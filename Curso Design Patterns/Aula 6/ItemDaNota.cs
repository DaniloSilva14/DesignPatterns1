using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }

        public String Nome { get; set; }
        public double Valor { get; set; }

    }
}
