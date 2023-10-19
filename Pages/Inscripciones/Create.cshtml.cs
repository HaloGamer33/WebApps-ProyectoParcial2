using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Universidad.Data;
using Universidad.Models;

namespace Universidad.Pages_Inscripciones
{
    public class CreateModel : PageModel
    {
        private readonly Universidad.Data.UniversidadContext _context;

        public CreateModel(Universidad.Data.UniversidadContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Inscripcion Inscripcion { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Inscripcion == null || Inscripcion == null)
            {
                return Page();
            }

            _context.Inscripcion.Add(Inscripcion);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
