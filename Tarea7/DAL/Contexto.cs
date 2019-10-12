using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea7.Entidades;


namespace Tarea7.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Asistencias> Asistencias{ get; set; }
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Estudiante> Estudiante{ get; set; }
        public DbSet<AsistenciaDetalle> AsistenciaDetalle { get; set; }
        public Contexto() : base("Constr")
        {

        }
    }
}
