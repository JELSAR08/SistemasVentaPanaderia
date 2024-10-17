using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define explícitamente la clave primaria de Producto
        modelBuilder.Entity<Producto>().HasKey(p => p.IdProducto);

        base.OnModelCreating(modelBuilder);
    }
}
