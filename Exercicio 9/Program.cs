using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de Pares e a Soma de Impares");
            Console.WriteLine();

            int preco = 0;
            int codigo = 0;
            int maiorPreco = 0;
            double totalPreco = 0;
            int i = 1;

            while (i <= 11)
            {

                Console.Write("Digite o código do " + i + "° produto: ");
                codigo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o preço do " + i + "° produto: ");
                preco = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=========================================");

                if (preco > maiorPreco)
                {
                    maiorPreco = preco;
                }

                totalPreco = totalPreco + preco;

                i++;
            }

            double media = totalPreco / 11;
            Console.WriteLine();

            Console.WriteLine("O maior preço é: " + maiorPreco );
            Console.WriteLine("E a média dos valores dos produtos é : " + media);

            Console.ReadKey();
        }
    }
}
