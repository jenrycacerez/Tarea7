using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea7.Entidades
{
     public  class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }

        public string Nombre { get; set; }


        public Estudiante()
        {
            EstudianteId = 0;
            Nombre = string.Empty;
        }
    }
}
