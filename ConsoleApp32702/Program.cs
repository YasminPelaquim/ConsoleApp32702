using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32702
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do litro de combustível? : ");
            double litro = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a distância a ser percorrida em km? : ");
            double km = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos km o veículo faz por litro? : ");
            double consumo = double.Parse(Console.ReadLine());

            double distancia  = km / consumo;

            double gasto = distancia * litro;

            Console.WriteLine("O total gasto na viagem é " + gasto);

            Console.ReadKey();
        }
    }
}
