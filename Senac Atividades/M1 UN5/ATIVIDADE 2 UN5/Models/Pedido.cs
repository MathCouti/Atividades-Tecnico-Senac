using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATIVIDADE_2.Models
{
    public class Pedido
    {
           
        private static List<ItemPedido> lista   = new List<ItemPedido>();
        
        
        public static void incluirpedido(ItemPedido pedido)
        {
           lista.Add(pedido);
        }

       
       

        public static double totalpedido()
        {
            double total= 0;
                for(int i=0; i < lista.Count; i++)
                {
                    total = lista[i].valor_unitario * lista[i].quantidade + total;
                }
                return total;
        }

        public static List<ItemPedido> Listar()
        {
            return lista;
        } 
        
    }
}