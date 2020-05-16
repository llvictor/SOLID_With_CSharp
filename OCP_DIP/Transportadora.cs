using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_DIP
{
    public class Transportadora : IServicoEntrega
    {
        public double Para(string cidade)
        {
            return 5;
        }
    }
}
