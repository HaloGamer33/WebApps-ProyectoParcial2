using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoParcial2.Data;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Pages_Estudiantes
{
    public class CreateModel : PageModel
    {
        private readonly ProyectoParcial2.Data.ProyectoParcial2Context _context;

        public CreateModel(ProyectoParcial2.Data.ProyectoParcial2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Estudiante == null || Estudiante == null)
            {
                return Page();
            }

            _context.Estudiante.Add(Estudiante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
