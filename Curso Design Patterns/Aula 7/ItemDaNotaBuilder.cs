using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    public class ItemDaNotaBuilder
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder paraItem(string nome) 
        {
            this.Nome = nome;
            return this;
        }

        public ItemDaNotaBuilder comValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}
