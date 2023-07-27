using System;
using System.Globalization;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10536.25m;
            Console.Write(valor);

            decimal valor2 = 10.25m;
            Console.Write(valor2.ToString(
                "C", CultureInfo.CreateSpecificCulture("pt-BR")
                ));
        }
    }
}
