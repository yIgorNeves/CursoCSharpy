using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();
            Console.WriteLine("Entre com os dados dos produtos");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            x.Quant = int.Parse(Console.ReadLine());       

            Console.WriteLine("Dados do Produto: " + x );

            Console.WriteLine("Digite o numero de produtos a ser adicionado do estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            x.AddQuant(qtd);
            Console.WriteLine("Dados Atualizados: " + x );

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            x.RemQuant(qtd);
            Console.WriteLine("Dados Atualizados: " + x );
        }
    }
}
