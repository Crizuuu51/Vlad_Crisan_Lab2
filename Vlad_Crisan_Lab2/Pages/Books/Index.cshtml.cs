using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vlad_Crisan_Lab2.Data;
using Vlad_Crisan_Lab2.Models;

namespace Vlad_Crisan_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Vlad_Crisan_Lab2.Data.Vlad_Crisan_Lab2Context _context;

        public IndexModel(Vlad_Crisan_Lab2.Data.Vlad_Crisan_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();

        }
    }
}
