using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto<T> : DbContext where T : class
    {
        public DbSet<T> Entity { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
