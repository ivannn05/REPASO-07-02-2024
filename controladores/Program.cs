/*Supongamos que estás desarrollando una aplicación para el registro 
    de actividades diarias. Esta aplicación tendrá las siguientes opciones: dar de
    alta una actividad, mostrar una actividad concreta en base al nombre de la actividad,
    eliminar actividad en base al nombre de la actividad. Cada actividad tiene un nombre,
    una fecha de inicio, una fecha de fin y una duración en minutos.

Alta de una actividad
Pide al usuario que ingrese el nombre de una actividad.
Pide al usuario que ingrese la fecha de inicio de la actividad.
La fecha de fin de la actividad será el instante en el que se
    guarde la actividad que se está dando de alta.
Con la fecha de inicio y fecha de fin calcula la duración en minutos de la actividad.

Eliminar actividad
Al seleccionar eliminar actividad, lo primero que se verá será un 
listado de actividades con los campos nombre y duración en minutos de la actividad.*/

using REPASO07022024.Dtos;
using REPASO07022024.servicios;

namespace REPASO07022024.controladores
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcion;
            bool cerrarMenu=false;
            List<actividadDto> listaActividades = new List<actividadDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();

            while(!cerrarMenu)
            {
                opcion = mi.MostrarMenuYSeleccion();
                Console.WriteLine(opcion);
                switch(opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        op.aniadirActividad(listaActividades);
                        break;
                    case 2:
                        op.mostrarActividad(listaActividades);
                        break;
                    case 3:
                        op.borrarActividad(listaActividades);
                        break;


                }

            }


        }
    }

}
