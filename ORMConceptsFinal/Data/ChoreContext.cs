using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ORMConceptsFinal.Models;

namespace ORMConceptsFinal.Data
{
    public class ChoreContext : IdentityDbContext
    {
        //public DbSet Users { get; set; }
        public DbSet<Chore> Chores { get; set; }
        public ChoreContext(DbContextOptions<ChoreContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Chores;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
