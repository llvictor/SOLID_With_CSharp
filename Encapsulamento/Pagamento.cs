﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        public MeioDePagamento Forma { get; private set; }

        public Pagamento(double valor, MeioDePagamento forma)
        {
            this.Valor = valor;
            this.Forma = forma;
        }

    }
}
