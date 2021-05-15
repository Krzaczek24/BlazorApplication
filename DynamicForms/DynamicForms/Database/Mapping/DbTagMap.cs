using DynamicForms.Database.Mapping.Base;
using DynamicForms.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping
{
    public class DbTagMap : DbBaseTableMap<DbTag>, IEntityTypeConfiguration<DbTag>
    {
        public DbTagMap(EntityTypeBuilder<DbTag> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbTag> builder)
        {
            builder.ToTable("Tag");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(256);

            builder.Property(e => e.Description)
                .HasColumnName("Description")
                .HasMaxLength(4000);
        }
    }
}
