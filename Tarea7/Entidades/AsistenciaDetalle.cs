using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7.Entidades
{
    public class AsistenciaDetalle
    {

        [Key]
        public int DetalleAsistenciasId { get; set; }

        public int AsistenciaId { get; set; }
        public int EstudianteId { get; set; }

        public string Nombre { get; set; }
        public bool Asistencia { get; set; }

        public AsistenciaDetalle()
        {
            this.DetalleAsistenciasId = 0;
            this.AsistenciaId = 0;
            this.EstudianteId = 0;
            this.Nombre="";
            this.Asistencia = false;

        }

    }
}


