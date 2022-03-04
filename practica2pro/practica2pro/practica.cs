using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2pro
{
    class practica
    {
    static void Main (string[] args)
        {
            Frasco frasco1 = new Frasco();
            frasco1.nombre = "acetaminofen";
            frasco1.presentacion = 40;
            Console.WriteLine("frasco1 nombre = {0} presentacion = {40}"), frasco1.nombre, frasco1.presentacion;

            Frasco frasco2 = frasco1;
            frasco2.nombre = "amoxicilina";
            frasco2.presentacion = 50;
            Console.WriteLine("frasco2 nombre = (0) presentacion = (40)"), frasco2.nombre, frasco2.presentacion;
            Console.WriteLine("frasco1 nombre = (0) presentacion = (50)"), frasco1.nombre, frasco1.presentacion;
            Console.WriteLine("presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
