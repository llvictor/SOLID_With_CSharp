﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_CSharp
{
    public abstract class Cargo
    {
        public IRegrasDeCalculo Regra { get; private set; }

        public Cargo(IRegrasDeCalculo regra)
        {
            this.Regra = regra;
        }
    }
}
