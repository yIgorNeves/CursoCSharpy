using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Entre com os dados dos produtos");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quant = int.Parse(Console.ReadLine());

            Produto x = new Produto(nome, preco, quant);

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
