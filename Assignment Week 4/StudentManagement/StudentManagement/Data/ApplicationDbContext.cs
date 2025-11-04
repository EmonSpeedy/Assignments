using Microsoft.EntityFrameworkCore;
using StudentManagement.Configurations;
using StudentManagement.Models;

namespace StudentManagement.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Student> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
