﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Vlad_Crisan_Lab2.Data.Vlad_Crisan_Lab2Context _context;

        public DetailsModel(Vlad_Crisan_Lab2.Data.Vlad_Crisan_Lab2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
