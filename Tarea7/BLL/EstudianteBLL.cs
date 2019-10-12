using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tarea7.DAL;
using Tarea7.Entidades;

namespace Tarea7.BLL
{
    class EstudianteBLL
    {
        public static bool Guardar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Estudiante.Add(estudiante) != null)
                {
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Estudiante estudiante)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(estudiante).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Estudiante estudiante = new Estudiante();

            try
            {
                estudiante = db.Estudiante.Find(id);
                db.Entry(estudiante).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Estudiante Buscar(int id)
        {
            Estudiante estudiante;
            Contexto db = new Contexto();

            try
            {
                estudiante = db.Estudiante.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiante;
        }

        public static List<Estudiante> GetList(Expression<Func<Estudiante, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Estudiante> lista = new List<Estudiante>();

            try
            {

                lista = db.Estudiante.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return lista;
        }

        public static bool Duplicado(string nick)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                paso = db.Estudiante.Any(p => p.Nombre == nick);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return paso;
        }
    }
}
