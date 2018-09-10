using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Repositorio<T> : IRepository<T> where T : class
    {
        public bool Guardar(T entity)
        {
            bool paso = false;
            Contexto<T> contexto = new Contexto<T>();
            try
            {
                contexto.Entity.Add(entity);
                contexto.SaveChanges();
                paso = true;

            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            

            return paso;
        }

        public bool Modificar(T entity)
        {
            bool paso = false;
            Contexto<T> contexto = new Contexto<T>();
            try
            {
                contexto.Entry(entity).State = EntityState.Modified;
                contexto.SaveChanges();
                paso = true;
                
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto<T> contexto = new Contexto<T>();
            try
            {
                T entity = contexto.Entity.Find(id);
                contexto.Entity.Remove(entity);
                contexto.SaveChanges();
                paso = true;                
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }


            return paso;
        }

        public T Buscar(int id)
        {
            T entity = null;
            Contexto<T> contexto = new Contexto<T>();
            try
            {
                entity = contexto.Entity.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return entity;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = null;
            Contexto<T> contexto = new Contexto<T>();
            try
            {
                Lista = contexto.Entity.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

       
    }
}
