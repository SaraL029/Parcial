using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
  
            string opcion = "0";

            Console.WriteLine("Bienvenido a la tienda de barrio: LePanite Desayunos");
            do
            {
                Console.WriteLine("\n" + "Este es nuestro menú de opciones");
                Console.WriteLine("\n" +
                    "\n 1. Buscar producto" +
                    "\n 2. Suma rápida de productos" +
                    "\n 3. Pagar cuenta" +
                    "\n 4. Consultar cuenta del cliente" +
                    "\n 5. Actualizar cuenta del cliente" +
                    "\n 6. Calcular informe de ventas" +
                    "\n 7. Calcular cartera de clientes, cuentas por pagar" +
                    "\n 8. Acerca de" +
                    "\n 9. Salir");

                Console.WriteLine("\n Por favor digite el número de la opción que desea");
                
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    // Buscar producto
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Has ingresado a la opción Buscar productos, presiona espacio para comenzar la búsqueda");
                        Console.ReadKey();
                        Console.WriteLine("\n" + "¿Cuántos productos desea buscar?");
                        string cantidad = Console.ReadLine();
                     
                        for (int i = 0; i < int.Parse(cantidad); i++)
                        {
                            Console.WriteLine("Ingrese el nombre del producto");
                            string productossuma = Console.ReadLine();

                            for (int k = 0; k < productos.Length; k++)
                            {
                                if (productos[k].Equals(productossuma))
                                {
                                    Console.WriteLine("El producto es: " + productos[k] + " tiene una valor de: " + precios[k]);
                                }
                            }
                        }
                        break;
                    //Suma rápida de productos
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Has ingresado a la opción Suma rápida de productos, presiona espacio para comenzar la búsqueda");
                        Console.ReadKey();

                        Console.WriteLine("\n" + "¿Cuántos productos desea llevar?");
                        string numero = Console.ReadLine();
                        int subtotal = 0;

                        for (int i = 0; i < int.Parse(numero); i++)
                        {
                            Console.WriteLine("Ingrese el nombre del producto");
                            string productossuma = Console.ReadLine();

                            for (int p = 0; p < productos.Length; p++)
                            {
                                if (productos[p].Equals(productossuma))
                                {
                                    Console.WriteLine("El producto es: " + productos[p] + " tiene una valor de: " + precios[p]);
                                    subtotal += precios[p];
                                }
                            }
                        }
                        Console.WriteLine("El precio total es: " + subtotal);
                        acumulador += subtotal;
                        break;
                    //Pagar la cuenta
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Has ingresado a la opción Pagar cuenta, presiona espacio para iniciar");
                        Console.ReadKey();
                        Console.WriteLine("\n"+ "El precio a pagar es de " + acumulador);
                        Console.WriteLine("¿Cómo desea pagar?" + "\n" + "1: Pagar" + "\n" + "2: Fiar");
                        string pago = Console.ReadLine();
                        
                        if (int.Parse(pago)== 1)
                        {
                            Console.WriteLine("Escogió la opción de pagar");
                            Console.WriteLine("¿Cón cuánto dinero va a pagar?");
                            string plata = Console.ReadLine();
                            int devuelta = int.Parse(plata) - acumulador;

                            Console.WriteLine("Su devuelta es de: " + devuelta);
                        }

                        if (int.Parse(pago)==2)
                        {
                            Console.WriteLine("Escogió la opción de fiar");
                            fiona += acumulador;
                        }
                        Console.WriteLine("Ahora su deuda es: " + fiona);
                        break;
                    case "4":
                        clases.clsOpcion4 opcion4 = new clases.clsOpcion4();
                        opcion4.ConsultarCuentaCliente();
                        break;
                    case "5":
                        clases.clsOpcion5 opcion5 = new clases.clsOpcion5();
                        opcion5.ActualizarCuentaCliente();
                        break;
                    case "6":
                        clases.clsOpcion6 opcion6 = new clases.clsOpcion6();
                        opcion6.InformeVentas();
                        break;
                    case "7":
                        clases.clsOpcion7 opcion7 = new clases.clsOpcion7();
                        opcion7.CarteraClientes();
                        break;
                    case "8":
                        clases.clsOpcion8 opcion8 = new clases.clsOpcion8();
                        opcion8.Creditos();
                        break;
                    case "9":
                        clases.clsOpcion9 opcion9 = new clases.clsOpcion9();
                        opcion9.Salir();
                        break;
                    default:
                        Console.WriteLine("No has escogido una opción válida :(");
                        break;
                }
                Console.ReadKey();

            }while (opcion != "0");

            
        }
    }
}
