using DynamicForms.Database.Enums;
using DynamicForms.Database.Mapping.Base;
using DynamicForms.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping
{
    public class DbFieldTypeMap : DbBaseTableMap<DbFieldType>, IEntityTypeConfiguration<DbFieldType>
    {
        public DbFieldTypeMap(EntityTypeBuilder<DbFieldType> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbFieldType> builder)
        {
            builder.ToTable("FieldType");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(256);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasMaxLength(256);

            builder.Property(e => e.DataValueType)
                .IsRequired()
                .HasColumnName("DataType")
                .HasConversion(v => (int)v, v => (DbDataValueType)v);
        }
    }
}
