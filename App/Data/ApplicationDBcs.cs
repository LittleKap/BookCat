using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class ApplicationDBcs : DbContext
    {
        public ApplicationDBcs(DbContextOptions<ApplicationDBcs> options) : base(options) 
        {

        }
        public DbSet<Autor> Authors {  get; set; }
    }
}
