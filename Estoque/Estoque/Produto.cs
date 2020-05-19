using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }

        public double TotalEstoque()
        {
            return Preco * Quant;
        }

        public void AddQuant(int qtd)
        {
            Quant += qtd;
        }

        public void RemQuant(int qtd)
        {
            Quant -= qtd;
        }

        public override string ToString()
        {
            return  Nome 
                    + ", R$" 
                    +Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", " 
                    +Quant 
                    + " unidades, Total: R$"
                    +TotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
