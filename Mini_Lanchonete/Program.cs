using System;
using System.Globalization;

namespace Mini_Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Item - - - - Lanche  - - - - Preço");
            Console.WriteLine("  1       Cachorro Quente    R$ 4.00");
            Console.WriteLine("  2          X-Salada        R$ 4.50");
            Console.WriteLine("  3          X-Bacon         R$ 5.00");
            Console.WriteLine("  4       Torrada Simples    R$ 2.00");
            Console.WriteLine("  5        Refrigerante      R$ 1.50");

            float cq = 4f;
            float xs = 4.50f;
            float xb = 5f;
            float ts = 2f;
            float refri = 1.50f;



            Console.WriteLine("Digite o item e a quantidade: ");
            string[] v = (Console.ReadLine().Split(' '));
            int item = int.Parse(v[0], CultureInfo.InvariantCulture);
            int qtd = int.Parse(v[1], CultureInfo.InvariantCulture);

            if (item == 1)
            {
                double total = cq * qtd;
                Console.WriteLine($"Total: R$ {total.ToString("f2", CultureInfo.InvariantCulture)} ");
            }
            else if (item == 2)
            {
                double total = xs * qtd;
                Console.WriteLine($"Total: R$ {total.ToString("f2", CultureInfo.InvariantCulture)} ");
            }
            else if (item == 3)
            {
                double total = xb * qtd;
                Console.WriteLine($"Total: R$ {total.ToString("f2", CultureInfo.InvariantCulture)} ");
            }
            else if (item == 4)
            {
                double total = ts * qtd;
                Console.WriteLine($"Total: R$ {total.ToString("f2", CultureInfo.InvariantCulture)} ");
            }
            else if (item == 5)
            {
                double total = refri * qtd;
                Console.WriteLine($"Total: R$ {total.ToString("f2", CultureInfo.InvariantCulture)} ");
            }
        }
    }
}