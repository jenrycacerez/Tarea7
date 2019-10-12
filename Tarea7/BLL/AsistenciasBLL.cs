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
    class AsistenciasBLL
    {
        public static bool Guardar(Asistencias asistencias)
        {
            bool flag = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Asistencias.Add(asistencias) != null)

                    flag = db.SaveChanges() > 0;


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return flag;
        }

        public static bool Modificar(Asistencias asistencias)
        {
            bool paso = false;
            Contexto db = new Contexto();

            //  List<AsistenciaDetalle> lista = new List<AsistenciasDetalles>();


            try
            {
           
                var anterior = db.Asistencias.Find(asistencias.AsistenciaId);
                foreach (var item in asistencias.Detalles)
                {
                    if (!anterior.Detalles.Exists(d => d.DetalleAsistenciasId == item.DetalleAsistenciasId))
                    {
                        db.AsistenciaDetalle.Add(item);
                        paso = (db.SaveChanges() > 0);
                    }

                  
                }

                foreach (var item in anterior.Detalles)
                {
                    if (!asistencias.Detalles.Exists(d => d.DetalleAsistenciasId == item.DetalleAsistenciasId))
                    {
                        db.AsistenciaDetalle.Remove(item);
                        paso = (db.SaveChanges() > 0);
                    }

                    
                }

               

            }
            catch (Exception)
            {
          //      throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static Asistencias Buscar(int id)
        {
            Asistencias asistencias = new Asistencias();
            Contexto db = new Contexto();

            try
            {
                asistencias = db.Asistencias.Find(id);
                if (asistencias != null)
                {
                    asistencias.Detalles.Count();
                }
                else
                {
                    db.Dispose();
                    return asistencias;
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

            return asistencias;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            // Asistencias asistencias = new Asistencias();

            try
            {
                var asistencias = db.Asistencias.Find(id);
                db.Entry(asistencias).State = EntityState.Deleted;
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

        public static List<Asistencias> GetList(Expression<Func<Asistencias, bool>> n)
        {
            List<Asistencias> Lista = new List<Asistencias>();
            Contexto db = new Contexto();

            try
            {

                Lista = db.Asistencias.Where(n).ToList();


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }


            return Lista;
        }
        public static bool Exist(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Asistencias.Find(id) != null)
                    paso = true;

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
