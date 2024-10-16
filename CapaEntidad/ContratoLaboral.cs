using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ContratoLaboral
    {
        int idContrato, idTipoContrato, idTrabajador, horasTotales;
        string descripcionContrato;
        bool estadoContrato;
        DateTime fechaInicioContrato, fechaFinContrato, fechaRegistroContrato;

        public int IdContrato { get => idContrato; set => idContrato = value; }
        public int IdTipoContrato { get => idTipoContrato; set => idTipoContrato = value; }
        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public int HorasTotales { get => horasTotales; set => horasTotales = value; }
        public string DescripcionContrato { get => descripcionContrato; set => descripcionContrato = value; }
        public bool EstadoContrato { get => estadoContrato; set => estadoContrato = value; }
        public DateTime FechaInicioContrato { get => fechaInicioContrato; set => fechaInicioContrato = value; }
        public DateTime FechaFinContrato { get => fechaFinContrato; set => fechaFinContrato = value; }
        public DateTime FechaRegistroContrato { get => fechaRegistroContrato; set => fechaRegistroContrato = value; }

        public ContratoLaboral()
        {

        }
    }
}
