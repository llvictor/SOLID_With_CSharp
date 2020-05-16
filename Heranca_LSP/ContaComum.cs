using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_LSP
{
    public class ContaComum
    {
        protected ManipuladorDeSaldo manipulador;

        public ContaComum()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }

        public void SomaInvestimento()
        {
            this.manipulador.SomaInvestimento(1.1);
        }

        public void Saca(double valor)
        {
            manipulador.Saca(valor);
        }

        public virtual void Deposita(double valor)
        {
            manipulador.Deposita(valor);
        }

        public double Saldo()
        {
            return manipulador.Saldo;
        }
    }
}
