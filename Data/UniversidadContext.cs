using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Universidad.Models;

namespace Universidad.Data
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext (DbContextOptions<UniversidadContext> options)
            : base(options)
        {
        }

        public DbSet<Universidad.Models.Estudiante> Estudiante { get; set; } = default!;

        public DbSet<Universidad.Models.Curso> Curso { get; set; } = default!;

        public DbSet<Universidad.Models.Inscripcion> Inscripcion { get; set; } = default!;
    }
}
