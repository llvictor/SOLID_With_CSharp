using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_LSP
{
    public class ContaEstudante : ContaComum
    {
        public int Milhas { get; private set; }

        public ContaEstudante() : base()
        {
        }

        public override void Deposita(double valor)
        {
            manipulador.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
