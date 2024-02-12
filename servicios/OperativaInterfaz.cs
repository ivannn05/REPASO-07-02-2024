using REPASO07022024.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPASO07022024.servicios
{
    internal interface OperativaInterfaz
    {
        public void aniadirActividad(List<actividadDto> listaActividades);
        public void mostrarActividad(List<actividadDto> listaActividades);
        public void borrarActividad(List<actividadDto> listaActividades);

    }
}
