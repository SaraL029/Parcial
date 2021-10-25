// Parcial II, Fundamentos de Programación. Octubre 2021.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] productos = { "chocolate", "pan tajado", "leche entera", "azucar", "cafe", "cereal", "mix de frutas" };
        int[] precios = { 3200, 2000, 3200, 6000, 1700, 8300, 4400, 3000, 5000 }; ;
        int[] usuario = { 001, 002, 003 };
        int[] estado_de_cuenta = { 0, 0, 0 };
        int contador = 0;
        int[] historial = new int[0];
        string verdadero;
        int acumulador = 0;
        int fiona = 0;

        string opcion = "0";

        // Menu, este expone el nombre de nuestra tienda (LePanite Desayunos) y todas las opciones de usuario del programa 

        Console.WriteLine("Bienvenido a la tienda de barrio: LePanite Desayunos");
        Console.WriteLine("Los productos disponibles son los siguientes:\n");

        for (int i = 0; i < productos.Length; i++)
        {
            Console.Write(productos[i] + "\n");
        }
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
                // Buscar producto, este permite buscar un producto por su nombre (segun la disponibilidad de la tienda) y decirle al usuario su valor
                case "1":
                    Console.Clear();
                    Console.WriteLine("Has ingresado a la opción Buscar productos, presiona espacio para comenzar la búsqueda");
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

                //Suma rápida de productos, este calcula la suma de los producto que el usuario está comprando en LePanite

                case "2":
                    contador++;
                    Array.Resize<int>(ref historial, contador);
                    Console.Clear();
                    Console.WriteLine("Has ingresado a la opción Suma rápida de productos, presiona espacio para comenzar la búsqueda");

                    Console.WriteLine("\n" + "¿Cuántos productos comprará el día de hoy?");
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
                    historial[contador - 1] = subtotal;
                    break;

                //Pagar la cuenta, este totaliza la cuenta del usuario, calcula el cambio necesario y ofrece la opcion de fiar
                case "3":
                    Console.Clear();
                    Console.WriteLine("Has ingresado a la opción Pagar cuenta, presiona espacio para iniciar");
                    Console.WriteLine("\n" + "El precio a pagar es de " + acumulador);
                    Console.WriteLine("¿Cómo desea pagar?" + "\n" + "1: Pagar" + "\n" + "2: Fiar");
                    string pago = Console.ReadLine();

                    if (int.Parse(pago) == 1)
                    {
                        Console.WriteLine("Escogió la opción de pagar");
                        Console.WriteLine("¿Cón cuánto dinero va a pagar?");
                        string plata = Console.ReadLine();
                        int devuelta = int.Parse(plata) - acumulador;

                        Console.WriteLine("Su devuelta es de: " + devuelta);
                    }

                    if (int.Parse(pago) == 2)
                    {
                        Console.WriteLine("Escogió la opción de fiar");
                        fiona = acumulador;
                    }
                    Console.WriteLine("Ahora su deuda es: " + fiona);
                    break;

                // Consultar cuenta cliente, este imprime el saldo actual del usuario, sea en deuda, saldo a favor o paz y salvo
                case "4":
                    Console.WriteLine("Por favor, digita tu usuario ");
                    string cliente = Console.ReadLine();


                    for (int a = 0; a < usuario.Length; a++)
                    {
                        if (usuario[a] == int.Parse(cliente))
                        {
                            Console.WriteLine("Su cuenta es: " + usuario[a] + " tiene un saldo de " + estado_de_cuenta[a]);
                            if (estado_de_cuenta[a] < 0)
                            {
                                Console.WriteLine("Te informamos que estas en deuda con LePanite Desayunos");
                            }

                            if (estado_de_cuenta[a] == 0)
                            {
                                Console.WriteLine("¡En buena hora! Estas a paz y salvo con LePanite");
                            }

                            if (estado_de_cuenta[a] > 0)
                            {
                                Console.WriteLine("¡Te esperamo pronto! Tienes saldo a favor con la tienda");
                            }
                        }

                    }


                    break;

                // Actualizar cuenta cliente, este actualiza el saldo de un cliente
                case "5":
                    Console.WriteLine("¿Cual es su ID?");
                    string consumidor = Console.ReadLine();
                    for (int d = 0; d < usuario.Length; d++)
                    {
                        if (usuario[d] == int.Parse(consumidor))
                        {
                            estado_de_cuenta[d] = -fiona;
                            Console.WriteLine("La cuenta: " + usuario[d] + " tiene un saldo de " + estado_de_cuenta[d]);
                        }
                    }
                    break;


                // Calcular informe de ventas, este imprime las compras durante la ejecución del programa y totaliza su valor
                case "6":
                    Console.WriteLine("Su historial de compras es el siguiente:");
                    for (int b = 0; b < historial.Length; b++)
                    {
                        Console.WriteLine("La compra numero: " + (b + 1) + " Tuvo un valor de: " + historial[b]);
                    }
                    Console.WriteLine("Y el total es de: " + acumulador);
                    break;

                // Calcular cartera de clientes y cuentas por pagar, este imprime el total de los saldos adeudados por los usuarios
                case "7":
                    Console.WriteLine("Ingrese su ID: ");
                    string comprador = Console.ReadLine();
                    for (int c = 0; c < usuario.Length; c++)
                    {
                        if (usuario[c]==int.Parse (comprador))
                        {
                            if (estado_de_cuenta[c] < 0)
                            {
                                Console.WriteLine("Usted debe el siguiente monto: " + estado_de_cuenta[c]);
                            }
                            if (estado_de_cuenta[c] == 0)
                            {
                                Console.WriteLine("Usted esta a paz y salvo ");
                            }
                        }
                    }
                    break;

                //Acerca de, este contiene los creditos e integrantes de la entrega
                case "8":
                    Console.Clear();
                    Console.WriteLine("Has ingresado a la opción de Acerca de, presiona espacio para iniciar");
                    Console.WriteLine("\n" + "Proyecto creado por:" + "\n" +
                    "\n" + "Sara Londoño Orrego " + " ID: 000437687" + "\n" +
                    "\n" + "AnaMaría Díaz Rocha " + " ID: 000436459" +
                    "\n" + "Para la clase de Fundamentos de Programación con el profesor Andrés Bedoya Tobón en el horario de martes y jueves a las 10am" + "\n" +
                    "\n" + "Universidad Pontificia Bolivariana" + "\n" + "2021");
                    break;

                //Salir, este le permite al usuario abandonar el proyecto
                case "9":
                    Console.Clear();
                    Console.WriteLine("Has escogido la opción de Salir, presiona espacio para ejecutar");
                    Console.WriteLine("\n" + "Gracias por visitarnos :D");

                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("No has escogido una opción válida :(");
                    break;
            }

        } while (opcion != "0");


    }
}
