using Microsoft.EntityFrameworkCore;
using SINOP.Domain.Entitys;

namespace SINOP.Infra.Data.EntityFrameworkCore;

public class SINOPContext : DbContext
{
    public SINOPContext(DbContextOptions<SINOPContext> options) : base(options){}

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Selo> Selo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());
        base.OnConfiguring(optionsBuilder);
    }
    public string GetConnectionString()
    {
        return @"Data Source = (localdb)\MSSQLLocalDb; Initial Catalog = SINOP; Integrated Security = True";
    }
}