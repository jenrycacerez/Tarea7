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
    class AsignaturasBLL
    {
        public static bool Guardar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Asignaturas.Add(asignaturas) != null)
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

        public static bool Modificar(Asignaturas asignaturas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(asignaturas).State = EntityState.Modified;
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
            Asignaturas asignaturas = new Asignaturas();

            try
            {
                asignaturas = db.Asignaturas.Find(id);
                db.Entry(asignaturas).State = EntityState.Deleted;
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

        public static Asignaturas Buscar(int id)
        {
            Asignaturas tipo;
            Contexto db = new Contexto();

            try
            {
                tipo = db.Asignaturas.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return tipo;
        }

        public static List<Asignaturas> GetList(Expression<Func<Asignaturas, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Asignaturas> lista = new List<Asignaturas>();

            try
            {

                lista = db.Asignaturas.Where(expression).ToList();

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

        public static bool Duplicado(string Nombree)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                paso = db.Asignaturas.Any(p => p.Nombre == Nombree);

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
