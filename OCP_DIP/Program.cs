using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDePrecos calculadora = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());
            Compra compra = new Compra("SAO PAULO", 500);

            double valor = calculadora.Calcula(compra);

            Console.WriteLine("O preço da compra é: " + valor);
            Console.ReadKey();
        }
    }
}
