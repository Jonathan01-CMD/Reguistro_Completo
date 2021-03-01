using Reguistro_Completo.DAL;
using Reguistro_Completo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Reguistro_Completo.BLL
{
    public class PermisosBLL
    {
        private static List<Permiso> GetList(Expression<Func<Permiso, bool>> criterio)
        {
            List<Permiso> lista = new List<Permiso>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Permiso.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static List<Permiso> GetPermisos()
        {
            List<Permiso> lista = new List<Permiso>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Permiso.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}
