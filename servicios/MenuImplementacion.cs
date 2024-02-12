using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MostrarMenuYSeleccion()
        {
            int opcion;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine("################################################");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.Dar de alta una actividad");
            Console.WriteLine("2.Mostrar actividad por el nombre");
            Console.WriteLine("3.Eliminar una actividad por el nombre");
            Console.WriteLine("################################################");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;

        }
    }
}
