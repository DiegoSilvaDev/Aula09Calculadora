using System;
using System.Threading;

namespace CalculadoraX
{
    class Program
    {
        static void Main(string[] args)
        {
            Contas Calcular = new Contas();

            Console.WriteLine("Calculadora iniciando");
            Thread.Sleep(300);
            Console.WriteLine("Loading...");
            Thread.Sleep(300);
            Console.WriteLine("Loading..");
            Thread.Sleep(300);
            Console.WriteLine("Loading.");
            Thread.Sleep(300);
            Console.WriteLine("Loading...");
            Thread.Sleep(300);
            Console.WriteLine("Loading.");
            Console.Clear();
            Console.WriteLine("Calculadora Ligada");
            Console.WriteLine();
            Console.WriteLine("Qual operação deseja? \nSomar? então digite um '+'\nSubtrair? então digite um '-'\nMultiplicar? então digite um 'x'\nDividir? então digite um '/'");
            Calcular.Calculos(Console.ReadLine());
        }
    }
}
