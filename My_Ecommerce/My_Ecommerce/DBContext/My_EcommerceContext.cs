using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using My_Ecommerce.Models.PracticeModel;

namespace My_Ecommerce.DBContext
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Student> student { get; set; }
    }
}
