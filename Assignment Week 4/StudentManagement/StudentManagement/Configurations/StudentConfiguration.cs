using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentManagement.Models;

namespace StudentManagement.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
            .IsRequired()
            .HasMaxLength(60);

        builder.HasIndex(s => s.Email)
            .IsUnique();
        builder.Property(s => s.Email)
            .IsRequired()
            .HasMaxLength(60);

        builder.Property(s => s.Department)
            .HasMaxLength(60);
    }
}
