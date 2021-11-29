using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_P1.Objetos
{
    public class Pedido
    {
        public int ID, Prioridad, Costo;
        public string pedido, Cliente;

        public Pedido(int ID, int Prioridad, int Costo, string pedido, string Cliente)
        {
            this.ID = ID;
            this.Prioridad = Prioridad;
            this.Costo = Costo;
            this.pedido = pedido;
            this.Cliente = Cliente;
        }

        public override string ToString()
        {
            return $"ID: {ID}\nPrioridad: {Prioridad}\nCosto: {Costo}\nPedido: {pedido}\nCliente: {Cliente}\n";
        }
    }
}
