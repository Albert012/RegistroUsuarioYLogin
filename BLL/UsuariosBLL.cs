using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuariosBLL
    {
        public static object FormsAuthentication { get; private set; }

        public static bool Authenticate(string usuario, string contrasena)
        {
            Usuarios usuarios = null;
            List<Usuarios> list = null;
            Contexto<Usuarios> contexto = new Contexto<Usuarios>();
            list = contexto.Set<Usuarios>().Where(u => u.Usuario.Equals(usuario) && u.Contrasena.Equals(contrasena)).ToList();
            usuarios = (list.Count > 0) ? list[0] : null;
            return (usuario != null);

        }

    }
}
