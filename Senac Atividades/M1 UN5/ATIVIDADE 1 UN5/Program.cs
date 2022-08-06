using System;

namespace ATIVIDADE_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido lista = new Pedido();
            string comando = "s";


            do{
            ItemPedido pedido1 = new ItemPedido();
            Console.WriteLine("Qual a descrição do pedido?");
            pedido1.descricao =Console.ReadLine();
            Console.WriteLine("Qual o valor do pedido?");
            pedido1.valor_unitario = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade do pedido?");
            pedido1.quantidade = int.Parse(Console.ReadLine());

            lista.incluirpedido(pedido1);

            Console.WriteLine("Adicionar novo pedido? [S/N]");
            comando= Console.ReadLine();
            if (comando == "n")
            {
                Console.WriteLine("O total do pedido é: R$" + lista.totalpedido());
            }
            }while (comando == "s");
            Console.WriteLine("Fim de programa");
            
        }


    }
}
