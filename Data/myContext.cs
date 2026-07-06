using crud_operations.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_operations.Data
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options) : base(options)
        { 
        }

        public DbSet<Student> tbl_students { get; set; }
    }
}
