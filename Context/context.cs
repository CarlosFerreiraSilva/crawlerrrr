using CoderCarrer.Models;
using Microsoft.EntityFrameworkCore;

namespace CoderCarrer.Context
{
    public class context : DbContext
    {

        public context(DbContextOptions<context> options) : base(options)
        {
        }

        public DbSet<Vaga> Vaga { get; set; }
    }
}
