using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boleto> listaDeBoletos = new List<Boleto>
            {
                new Boleto(150.75),
                new Boleto(300),
            };
            Fatura fatura = new Fatura("Victor", 450.75);
            ProcessadorDeBoletos procBoleto = new ProcessadorDeBoletos();

            procBoleto.Processa(listaDeBoletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadKey();
        }
    }
}
