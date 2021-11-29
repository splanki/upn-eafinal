using Final_P1.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_P1.Objetos.ArbolBinario;

namespace Final_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbolbinario a = new Arbolbinario();

            a.InsertarNodo(new Pedido(5,2,12,"Salchipapa","Juan"));
            a.InsertarNodo(new Pedido(3, 2, 10, "Gaseosa 1 Litro", "Karla"));
            a.InsertarNodo(new Pedido(7, 2, 8, "Alita Broaster", "Ximena"));
            a.InsertarNodo(new Pedido(13,2, 15, "Pecho Broaster", "Alice"));
            a.InsertarNodo(new Pedido(9, 2, 20, "Pollo a la brasa", "Joaquin"));

            Console.WriteLine("Listado de pedidos preorden: ");
            a.Preorden(a.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Listado de pedidos inorden: ");
            a.Inorden(a.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Listado de pedidos postorden: ");
            a.Postorden(a.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Agregando nuevo pedido...");

            a.InsertarNodo(new Pedido(22, 0, 25, "Parillada para 5 personas", "Alexandra"));
            Console.WriteLine("Listado de pedidos preorden: ");
            a.Postorden(a.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Listado de pedidos preorden: ");
            a.Preorden(a.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Listado de pedidos inorden: ");
            a.Inorden(a.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("Listado de pedidos postorden: ");
            a.Postorden(a.GetRaiz());
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
