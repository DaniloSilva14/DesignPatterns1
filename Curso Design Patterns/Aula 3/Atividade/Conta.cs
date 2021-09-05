using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    class Conta
    {
        public Conta(string nome, int numero, int agencia, float saldo)
        {
            Nome = nome;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public float Saldo { get; set; }
    }
}
