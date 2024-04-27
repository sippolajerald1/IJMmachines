using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IJMmachines.Data;
using IJMmachines.Models;

namespace IJMmachines.Pages.Machines
{
    public class DetailsModel : PageModel
    {
        private readonly IJMmachines.Data.IJMmachinesContext _context;

        public DetailsModel(IJMmachines.Data.IJMmachinesContext context)
        {
            _context = context;
        }

        public Machine Machine { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var machine = await _context.Machine.FirstOrDefaultAsync(m => m.Id == id);
            if (machine == null)
            {
                return NotFound();
            }
            else
            {
                Machine = machine;
            }
            return Page();
        }
    }
}
