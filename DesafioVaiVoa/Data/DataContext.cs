
using DesafioVaiVoa.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioVaiVoa.Data
{
    public class DataContext : DbContext
    {
        private string conn = "server=localhost;Database=desafiovaivoa; User Id = sa; Password=ceub";
        public DbSet<Card> Cards { get; set; }
        public DbSet<Pessoa> Pessoas {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(conn);
        }

    }
    

    
}
