using System;
using System.Collections.Generic; //o comando list está dentro desse using system
using System.Linq;
using System.Threading.Tasks;

namespace ATIVIDADE_1
{
    public class Pedido
    {
           
        private List<ItemPedido> lista   = new List<ItemPedido>();
        

        public void incluirpedido(ItemPedido pedido)
        {
           lista.Add(pedido);
        }

       
       

        public double totalpedido()
        {
            double total= 0;
                for(int i=0; i < lista.Count; i++)
                {
                    total = lista[i].valor_unitario * lista[i].quantidade + total;
                }
                return total;
        }

    }
}