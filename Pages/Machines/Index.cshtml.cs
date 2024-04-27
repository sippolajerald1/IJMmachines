using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IJMmachines.Data;
using IJMmachines.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IJMmachines.Pages.Machines
{
    public class IndexModel : PageModel
    {
        private readonly IJMmachines.Data.IJMmachinesContext _context;

        public IndexModel(IJMmachines.Data.IJMmachinesContext context)
        {
            _context = context;
        }

        public IList<Machine> Machine { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Manufacturer { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MachineManufacturers { get; set; }


        public async Task OnGetAsync()
        {
            
            // Use LINQ to get list of MachineCost
          /*  IQueryable<decimal> MachineCostQuery = from m in _context.Machine
                                                  orderby m.MachineCost
                                                  select m.MachineCost;

            */
            
            var machines = from m in _context.Machine
                           select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                machines = machines.Where(s => s.Manufacturer.Contains(SearchString));
            }
/*
            if (!decimal.IsNullOrEmpty(MachineCost))
            {
                machines=machines.Where(x => x.MachineCost == MachineCost);
            }
*/
           // MachineCost = new SelectList(await genreQuery.Distinct().ToListAsync());
            Machine = await machines.ToListAsync();
        }
    }
}
