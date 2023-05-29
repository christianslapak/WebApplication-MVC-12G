using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_MVC_12G.Models;

namespace WebApplication_MVC_12G.Context
{
    public class EscuelaDBContext : DbContext
    {
        public EscuelaDBContext(DbContextOptions<EscuelaDBContext> options) : base(options)
        {
        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
