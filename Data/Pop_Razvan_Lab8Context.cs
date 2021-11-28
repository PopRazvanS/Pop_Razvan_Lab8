using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_Razvan_Lab8.Models;

namespace Pop_Razvan_Lab8.Data
{
    public class Pop_Razvan_Lab8Context : DbContext
    {
        public Pop_Razvan_Lab8Context (DbContextOptions<Pop_Razvan_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_Razvan_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pop_Razvan_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pop_Razvan_Lab8.Models.Category> Category { get; set; }
    }
}
