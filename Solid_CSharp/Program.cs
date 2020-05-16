using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario func = new Funcionario(new Desenvolvedor(new QuinzeOuVinteCincoPorcento()), 3500);

            double salario = calculadora.Calcula(func);

            Console.WriteLine("Salário calculado: R$" + salario);
            Console.ReadKey();
        }
    }
}
