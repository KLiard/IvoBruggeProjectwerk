using System.Data;
using CourseScheduler.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseScheduler.EF.Configuration
{
    public class ModuleConfiguration
        : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.ToTable("Modules");

            builder.Property(m => m.Code)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(m => m.Naam)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(m => m.Lestijden)
                .IsRequired();

            builder.Property(m => m.Studierichting)
                .HasColumnType(nameof(DbType.Int32))
                .IsRequired();
        }
    }
}