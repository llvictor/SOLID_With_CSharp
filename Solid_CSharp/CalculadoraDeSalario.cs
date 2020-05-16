﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_CSharp
{
    public class CalculadoraDeSalario
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalculaSalario();
        }
    }
}
