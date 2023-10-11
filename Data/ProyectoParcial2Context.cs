using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Data
{
    public class ProyectoParcial2Context : DbContext
    {
        public ProyectoParcial2Context (DbContextOptions<ProyectoParcial2Context> options)
            : base(options)
        {
        }

        public DbSet<ProyectoParcial2.Models.Estudiante> Estudiante { get; set; } = default!;

        public DbSet<ProyectoParcial2.Models.Curso> Curso { get; set; } = default!;

        public DbSet<ProyectoParcial2.Models.Inscripcion> Inscripcion { get; set; } = default!;
    }
}
