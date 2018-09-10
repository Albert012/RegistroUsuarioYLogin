using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string  Contrasena { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Usuario = string.Empty;
            Nombre = string.Empty;
            Tipo = string.Empty;
            Contrasena = string.Empty;
        }


    }
}
