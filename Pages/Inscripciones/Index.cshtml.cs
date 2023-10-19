using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Universidad.Data;
using Universidad.Models;

namespace Universidad.Pages_Inscripciones
{
    public class IndexModel : PageModel
    {
        private readonly Universidad.Data.UniversidadContext _context;

        public IndexModel(Universidad.Data.UniversidadContext context)
        {
            _context = context;
        }

        public IList<Inscripcion> Inscripcion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Inscripcion != null)
            {
                Inscripcion = await _context.Inscripcion.ToListAsync();
            }
        }
    }
}
