using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TipoContratoLaboral
    {
        int idTipoContrato;
        string nombreTipoContrato;
        decimal salarioBaseTipoContrato;
        DateTime fechaRegistroTipoContrato;
        bool estadoTipoContrato;

        public int IdTipoContrato { get => idTipoContrato; set => idTipoContrato = value; }
        public string NombreTipoContrato { get => nombreTipoContrato; set => nombreTipoContrato = value; }
        public decimal SalarioBaseTipoContrato { get => salarioBaseTipoContrato; set => salarioBaseTipoContrato = value; }
        public DateTime FechaRegistroTipoContrato { get => fechaRegistroTipoContrato; set => fechaRegistroTipoContrato = value; }
        public bool EstadoTipoContrato { get => estadoTipoContrato; set => estadoTipoContrato = value; }

        public TipoContratoLaboral()
        {

        }
    }
}
