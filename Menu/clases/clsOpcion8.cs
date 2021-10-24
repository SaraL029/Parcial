using System;
using System.Collections.Generic;
using System.Text;

namespace Menu.clases
{
    public class clsOpcion8
    {
        public void Creditos()
        {
            Console.Clear();
            Console.WriteLine("Has escogido la opción de Acerca de");
            Console.ReadKey();
            
            Console.WriteLine("\n" + "Proyecto creado por:" + "\n" +
             "\n" + "AnaMaría Díaz Rocha " + " ID: 000436459" +
             "\n" + "Sebastián Bello Garcia" + " ID: 000385812" +
             "\n" + "Sara Londoño Orrego " + " ID: 000437687" + "\n" +
             "\n" + "Para la clase de Fundamentos de Programación con el profesor Andrés Bedoya Tobón los martes y jueves a las 10am"+ "\n"+
             "\n" + "Universidad Pontificia Bolivariana" + "\n"+ "2021");
   
        }
    }
}
