using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.Dtos
{
    internal class actividadDto
    {
        
        string nombreDeActividad ="aaaaa";
        DateTime fechaInicioActividad = new DateTime(9999, 12, 31, 0, 0, 0);
        DateTime fechaFinActividad = new DateTime(9999, 12, 31, 0, 0, 0);
        
        public actividadDto()
        {
        }

        public actividadDto(string nombreDeActividad, DateTime fechaInicioActividad, DateTime fechaFinActividad)
        {
            this.nombreDeActividad = nombreDeActividad;
            this.fechaInicioActividad = fechaInicioActividad;
            this.fechaFinActividad = fechaFinActividad;
        }

        public string NombreDeActividad { get => nombreDeActividad; set => nombreDeActividad = value; }
        public DateTime FechaInicioActividad { get => fechaInicioActividad; set => fechaInicioActividad = value; }
        public DateTime FechaFinActividad { get => fechaFinActividad; set => fechaFinActividad = value; }

        override

         public string ToString()
        {
            string datos = "\tNombre=" + this.nombreDeActividad+"\n"
                + "\tFecha Inicio=" + this.fechaInicioActividad+"\n"
                + "\tFecha Fin=" + this.fechaFinActividad;

            return datos;
        }

    }
}
