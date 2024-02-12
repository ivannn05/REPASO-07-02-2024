using REPASO07022024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        

        public void borrarActividad(List<actividadDto> listaActividades)
        {
            actividadDto actividadABorrar = new actividadDto();
            string nombre = pedirNombre();
            foreach (actividadDto actividadDto in listaActividades)
            {
                if (nombre.Equals(actividadDto.NombreDeActividad))
                {
                    actividadABorrar = actividadDto;
                    break;
                }

            }
            listaActividades.Remove(actividadABorrar);
            Console.WriteLine("\t\tLa actividad se ha borrado");
        }

        private actividadDto darAltaActividad()
        {
            actividadDto actividad = new actividadDto();

            Console.WriteLine("\tIntroduzca el nombre de la actividad");
           actividad.NombreDeActividad =Console.ReadLine();

            Console.WriteLine("\tIntroduzca la fecha de inicio de la actividad");
          actividad.FechaInicioActividad= Convert.ToDateTime(Console.ReadLine());

           actividad.FechaFinActividad = DateTime.Now;

           

            return actividad;

        }
        public void aniadirActividad(List<actividadDto> listaActividades) 
        {
            actividadDto actividad = darAltaActividad();
            listaActividades.Add(actividad);
        }

        public void mostrarActividad(List<actividadDto> listaActividades)
        {
            /*Falta crear una actividad para usarla */
            string nombre=pedirNombre();

            foreach (actividadDto actividadDto in listaActividades)
            {
                if (nombre.Equals(actividadDto.NombreDeActividad))
                {
                        Console.WriteLine(actividadDto.ToString());

                        TimeSpan diferencia = actividadDto.FechaFinActividad.Subtract(actividadDto.FechaInicioActividad);
                        Console.WriteLine("\tLa duracion en minutos es de =" + diferencia.TotalMinutes);
                    
                }
               
            }
        }

        private string pedirNombre()
        {
            Console.WriteLine("\tIntroduzca el nombre de la actividad");
            string nombre=Console.ReadLine();

            return nombre;

        }
    }
}
