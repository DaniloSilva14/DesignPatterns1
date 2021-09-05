using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Design_Patterns
{
    interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
    }

    class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; private set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

    class RespostaEmCsv : IResposta
    {
        public IResposta OutraResposta { get; private set; }

        public RespostaEmCsv(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

    class RespostaEmPorcento : IResposta
    {
        private IResposta OutraResposta { get; set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            this.OutraResposta = null; // nao recebi a proxima!
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + '%' + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(req, conta);
            }
            else
            {
                // não existe próxima na corrente, e ninguém atendeu a requisição!
                // poderíamos não ter feito nada aqui, caso não fosse necessário!
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
