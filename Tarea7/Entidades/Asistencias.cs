using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7.Entidades
{
    public class Asistencias
    {
        [Key]
        public int AsistenciaId { get; set; }

        public DateTime Fecha { get; set; }

        public int EstudiantesId { get; set; }
        public int AsignaturaId { get; set; }

        public int Cantidad { get; set; }
        public virtual List<AsistenciaDetalle> Detalles { get; set; }

        public Asistencias()
        {
            AsistenciaId = 0;
            Fecha = DateTime.Now;
            AsignaturaId = 0;
            Cantidad = 0;
           Detalles = new List<AsistenciaDetalle>();
        }


    }
}
