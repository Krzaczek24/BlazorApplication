using DynamicForms.Database.Mapping.Base;
using DynamicForms.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping
{
    public class DbFormDataMap : DbBaseTableMap<DbFormData>, IEntityTypeConfiguration<DbFormData>
    {
        public DbFormDataMap(EntityTypeBuilder<DbFormData> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbFormData> builder)
        {
            builder.ToTable("FormData");

            builder.Property(e => e.StringValue)
                .HasColumnName("StringValue")
                .HasMaxLength(4000);

            builder.Property(e => e.IntValue)
                .HasColumnName("IntValue");

            builder.Property(e => e.DecimalValue)
                .HasColumnName("DecimalValue");

            builder.Property(e => e.DateTimeValue)
                .HasColumnName("DateTimeValue");

            builder.HasOne(e => e.FormField)
                .WithMany(e => e.FieldData)
                .HasForeignKey("FieldId");

            builder.HasOne(e => e.Form)
                .WithMany(e => e.FormData)
                .HasForeignKey("FormId");
        }
    }
}
