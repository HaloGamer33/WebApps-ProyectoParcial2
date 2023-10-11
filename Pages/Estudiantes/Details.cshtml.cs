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
    public class DetailsModel : PageModel
    {
        private readonly ProyectoParcial2.Data.ProyectoParcial2Context _context;

        public DetailsModel(ProyectoParcial2.Data.ProyectoParcial2Context context)
        {
            _context = context;
        }

      public Estudiante Estudiante { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Estudiante == null)
            {
                return NotFound();
            }

            var estudiante = await _context.Estudiante.FirstOrDefaultAsync(m => m.Id == id);
            if (estudiante == null)
            {
                return NotFound();
            }
            else 
            {
                Estudiante = estudiante;
            }
            return Page();
        }
    }
}
