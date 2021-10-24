using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.clases
{
    public class clsOpcion1
    {
        public void BuscarProducto()
        {
            Console.Clear();
            Console.WriteLine("Has ingresado a la opción Buscar producto");
            Console.ReadKey();
            Console.WriteLine("Bienvenido a la tienda de barrio: LePanite Desayunos");

                string[] productos = { "chocolate", "pan tajado", "leche entera", "waffles", "azucar", "cafe", "cereal", "arepas", "mix de frutas" };
                float[] precios = { 3200, 2000, 3200, 6000, 1700, 8300, 4400, 3000, 5000 };
                string datos;
                string verdadero;
                float acumulador = 0;

                Console.WriteLine("Los productos disponibles son los siguientes:\n");

                for (int i = 0; i < productos.Length; i++)
                {
                    Console.Write(productos[i] + "\n");
                }

                for (int i = 0; i < productos.Length; i++)
                {
                    Console.WriteLine("Por favor ingrese el nombre del producto que desea adquirir");
                    datos = Console.ReadLine().ToLower();

                    if (datos == "chocolate" && "chocolate" == productos[i])
                    {
                        Console.Write($"El producto que buscas es: {productos[i]}, el cual tiene un precio de {precios[i]} cop\n");
                        Console.WriteLine("¿Deseas comprar este producto?");
                        verdadero = Console.ReadLine().ToLower();

                        if (verdadero == "si")
                        {
                            acumulador = precios[i];
                            Console.Write($"Total a pagar : {acumulador}\n");
                        }

                        else
                        {
                            Console.WriteLine("Gracias por tu visita");
                            break;
                        }

                    }

                    else
                    {
                        Console.WriteLine("Haz digitado un producto que no está en nuestra tienda, vuelve a intentarlo");
                    }
                }
        }
    }
}
