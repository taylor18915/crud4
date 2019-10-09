using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using crud4.Data;

namespace crud4.Pages.depts
{
    public class CreateModel : PageModel
    {
        private readonly crud4.Data.ApplicationDbContext _context;

        public CreateModel(crud4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public departments departments { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.departments.Add(departments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}