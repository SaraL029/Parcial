using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.clases
{
    public class clsOpcion9
    {
        public void Salir()
        {
            Console.Clear();
            Console.WriteLine("Has escogido la opción de Salir");
            Console.WriteLine("\n" + "Gracias por visitarnos :D");
            Console.ReadKey();

            Environment.Exit(1);

        }
        

    }
}
