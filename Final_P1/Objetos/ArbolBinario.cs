using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_P1.Objetos
{
    class ArbolBinario
    {
        public class Arbolbinario
        {
            public Nodo raiz;

            public Nodo GetRaiz()
            {
                return raiz;
            }

            public void Recorrer()
            {
                Nodo temp = GetRaiz();
                Nodo temp2 = temp;
                while (temp2 != null)
                {
                    temp2 = temp.derecho;
                    Console.WriteLine(temp.pedido.ToString());
                }

            }

            public void Inorden(Nodo raiz)
            {
                if (raiz != null)
                {
                    Inorden(raiz.izquierdo);
                    Console.WriteLine(raiz.pedido.ToString());
                    Inorden(raiz.derecho);
                }
            }

            public void Preorden(Nodo raiz)
            {
                if (raiz != null)
                {
                    Console.WriteLine(raiz.pedido.ToString());
                    Preorden(raiz.izquierdo);
                    Preorden(raiz.derecho);
                }
            }

            public void Postorden(Nodo raiz)
            {
                if (raiz != null)
                {
                    Postorden(raiz.izquierdo);
                    Postorden(raiz.derecho);
                    Console.WriteLine(raiz.pedido.ToString());
                }
            }

            public void InsertarNodo(Pedido x)
            {
                Nodo puntero;
                Nodo padre;
                Nodo nodo = new Nodo
                {
                    pedido = x
                };
                if (raiz != null)
                {
                    puntero = raiz;
                    while (true)
                    {
                        padre = puntero;
                        if (x.Prioridad < puntero.pedido.Prioridad)
                        {
                            puntero = puntero.izquierdo;
                            if (puntero == null)
                            {
                                padre.izquierdo = nodo;
                                break;
                            }
                        }
                        else
                        {
                            puntero = puntero.derecho;
                            if (puntero == null)
                            {
                                padre.derecho = nodo;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    raiz = nodo;
                }
            }

            public void BuscarPorLlave(int key)
            {
                int contador = 0;
                Nodo puntero = raiz;
                while (puntero != null)
                {
                    contador += 1;
                    if (puntero.pedido.ID == key)
                    {
                        Console.WriteLine("encontrada:  {0} ", puntero.pedido.ToString());
                        Console.WriteLine("Total de iteraciones:" + contador + 1);
                        return;
                    }
                    else
                    {
                        if (key > puntero.pedido.ID)
                        {
                            puntero = puntero.derecho;
                        }
                        else
                        {
                            puntero = puntero.izquierdo;
                        }
                    }
                }
                Console.WriteLine("No se encontró");
                Console.WriteLine("Total de iteraciones:" + contador);
            }

            public void BuscarPorValor(Nodo puntero, Pedido x, int contador)
            {
                if (puntero != null)
                {
                    contador += 1;
                    if (puntero.pedido.pedido == x.pedido)
                    {
                        Console.WriteLine("Historial {0} encontrado en posición {1}", puntero.pedido.pedido, puntero.pedido.ID);
                        Console.WriteLine("Total de iteraciones:" + contador + 1);
                        return;
                    }
                    BuscarPorValor(puntero.izquierdo, x, contador);
                    BuscarPorValor(puntero.derecho, x, contador);
                }
                else
                {
                    Console.WriteLine("Total de iteraciones:" + contador);
                }
            }
        }
    }
}
