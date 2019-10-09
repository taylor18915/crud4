using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud4.Data;

namespace crud4.Pages.depts
{
    public class IndexModel : PageModel
    {
        private readonly crud4.Data.ApplicationDbContext _context;

        public IndexModel(crud4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<departments> departments { get;set; }

        public async Task OnGetAsync()
        {
            departments = await _context.departments.ToListAsync();
        }
    }
}
