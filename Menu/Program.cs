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
                    case "1":
                        clases.clsOpcion1 opcion1 = new clases.clsOpcion1();
                        opcion1.BuscarProducto();
                        break;
                    
                    case "2":
                        clases.clsOpcion2 opcion2 = new clases.clsOpcion2();
                        opcion2.SumaProductos();
                        break;

                    case "3":
                        clases.clsOpcion3 opcion3 = new clases.clsOpcion3();
                        opcion3.PagarCuenta();
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
