using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_DIP
{
    public class Compra
    {
        public string Cidade { get; set; }
        public double Valor { get; set; }

        public Compra(string cidade, double valor)
        {
            this.Cidade = cidade;
            this.Valor = valor;
        }
    }
}
