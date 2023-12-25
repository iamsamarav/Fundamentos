using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Produto { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é " +
            $"{Nome} e tenho {Idade} anos");
        }
        public void Comprar()
        {
            decimal carteira = 75.5m;
            decimal valorProduto = Produto;

            carteira -= valorProduto;

            Console.WriteLine($"Você adquiriu o produto, agora tem disponível: {carteira}");
            Environment.Exit();
        }
    }
}