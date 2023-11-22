using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Modelos;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Entidades.BaseDeDatos
{
    public class GestorBaseDeDatos : DbContext
    {
        public DbSet<Vendedor> vendedor { get; set; }
        public DbSet<Producto> producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-NP3CB0L\\MSSQLSERVER777; Database = Programacion2; Trusted_Connection = True; TrustServerCertificate = Yes;");
        }
    }   
        
}
