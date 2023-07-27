using System;

namespace H_MOD13_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[2];
            meuArray[0] = 12;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);


            var meuArray2 = new int[5] { 10, 20, 40, 45, 50 };

            for (var index = 0; index < meuArray2.Length; index++)
            {
                Console.WriteLine(meuArray2[index]);
            }

            var meuArray3 = new int[5] { 11223, 232130, 41230, 4532424, 50 };

            foreach (var item in meuArray3)
                Console.WriteLine(item);

            var funcionarios = new Funcionario[2];
            funcionarios[0] = new Funcionario() { id = 1987, Nome = "Tiago Castro" };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.id);
                Console.WriteLine(funcionario.Nome);
            }
        }

        public struct Funcionario
        {
            public int id { get; set; }
            public string Nome { get; set; }
        }

    }
}
