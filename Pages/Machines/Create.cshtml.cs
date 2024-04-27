using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IJMmachines.Data;
using IJMmachines.Models;

namespace IJMmachines.Pages.Machines
{
    public class CreateModel : PageModel
    {
        private readonly IJMmachines.Data.IJMmachinesContext _context;

        public CreateModel(IJMmachines.Data.IJMmachinesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Machine Machine { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Machine.Add(Machine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
