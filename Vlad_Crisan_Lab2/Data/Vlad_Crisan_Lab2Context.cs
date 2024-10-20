using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vlad_Crisan_Lab2.Models;

namespace Vlad_Crisan_Lab2.Data
{
    public class Vlad_Crisan_Lab2Context : DbContext
    {
        public Vlad_Crisan_Lab2Context (DbContextOptions<Vlad_Crisan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vlad_Crisan_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Vlad_Crisan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
