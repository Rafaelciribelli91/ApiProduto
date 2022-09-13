using API_Produto.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Produto.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
