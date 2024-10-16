using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Trabajador
    {
        int idTrabajador;
        string nombreTrabajador;
        string apellidoPatTrabajador;
        string apellidoMatTrabajador;
        string documentoTrabajador;
        string direccionTrabajador;
        string telefonoTrabajador;
        string correoTrabajador;
        DateTime? fechaRegistroTrabajador;
        bool estadoTrabajador;

        public int IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public string NombreTrabajador { get => nombreTrabajador; set => nombreTrabajador = value; }
        public string ApellidoPatTrabajador { get => apellidoPatTrabajador; set => apellidoPatTrabajador = value; }
        public string ApellidoMatTrabajador { get => apellidoMatTrabajador; set => apellidoMatTrabajador = value; }
        public string DocumentoTrabajador { get => documentoTrabajador; set => documentoTrabajador = value; }
        public string DireccionTrabajador { get => direccionTrabajador; set => direccionTrabajador = value; }
        public string TelefonoTrabajador { get => telefonoTrabajador; set => telefonoTrabajador = value; }
        public string CorreoTrabajador { get => correoTrabajador; set => correoTrabajador = value; }
        public DateTime? FechaRegistroTrabajador { get => fechaRegistroTrabajador; set => fechaRegistroTrabajador = value; }
        public bool EstadoTrabajador { get => estadoTrabajador; set => estadoTrabajador = value; }

        public Trabajador()
        {
        }
    }
}
