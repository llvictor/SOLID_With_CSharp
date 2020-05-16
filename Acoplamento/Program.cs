using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            Fatura fatura = new Fatura(4.200, "Victor");
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());

            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
            gnf.Gera(fatura);

            Console.ReadKey();
        }
    }
}
