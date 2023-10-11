using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProyectoParcial2.Data;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Pages_Estudiantes
{
    public class IndexModel : PageModel
    {
        private readonly ProyectoParcial2.Data.ProyectoParcial2Context _context;

        public IndexModel(ProyectoParcial2.Data.ProyectoParcial2Context context)
        {
            _context = context;
        }

        public IList<Estudiante> Estudiante { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Estudiante != null)
            {
                Estudiante = await _context.Estudiante.ToListAsync();
            }
        }
    }
}
