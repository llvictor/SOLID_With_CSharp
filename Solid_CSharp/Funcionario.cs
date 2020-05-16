﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_CSharp
{
    public class Funcionario
    {
        public Cargo Cargo { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }

        public double CalculaSalario()
        {
            return this.Cargo.Regra.Calcula(this);
        }
    }
}
