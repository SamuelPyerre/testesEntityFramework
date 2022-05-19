using Banco.Models;
using Microsoft.EntityFrameworkCore;

namespace Banco.Data
{
    public class BancoDataContext : DbContext
    {
        public DbSet<ClienteModel> Clientes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Banco;User=sa;Password=1q2w3e4r@#$");
        
    }
}