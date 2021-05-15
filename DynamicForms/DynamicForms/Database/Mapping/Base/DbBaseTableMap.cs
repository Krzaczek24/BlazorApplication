using DynamicForms.Database.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping.Base
{
    public abstract class DbBaseTableMap<T> where T : DbBaseTable
    {
        public DbBaseTableMap(EntityTypeBuilder<T> builder)
        {
            builder.HasKey("Id");

            builder.Property(e => e.Id).HasColumnName("Id");

            builder.Property(e => e.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasDefaultValueSql("true");

            builder.Property(e => e.AddDate)
                .IsRequired()
                .HasColumnName("AddDate")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(e => e.AddLogin)
                .IsRequired()
                .HasColumnName("AddLogin")
                .HasMaxLength(256);

            builder.Property(e => e.ModifDate)
                .HasColumnName("ModifDate");

            builder.Property(e => e.ModifLogin)
                .HasColumnName("ModifLogin")
                .HasMaxLength(256);
        }
    }
}
