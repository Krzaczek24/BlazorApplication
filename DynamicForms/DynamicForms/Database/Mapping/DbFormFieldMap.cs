using DynamicForms.Database.Mapping.Base;
using DynamicForms.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping
{
    public class DbFormFieldMap : DbBaseTableMap<DbFormField>, IEntityTypeConfiguration<DbFormField>
    {
        public DbFormFieldMap(EntityTypeBuilder<DbFormField> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbFormField> builder)
        {
            builder.ToTable("FormField");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(256);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasMaxLength(256);

            builder.Property(e => e.Code)
                .HasColumnName("Code")
                .HasMaxLength(256);

            builder.HasOne(e => e.FormTemplate)
                .WithMany(e => e.FormFields)
                .HasForeignKey("TemplateId");

            builder.HasOne(e => e.FieldType)
                .WithMany()
                .HasForeignKey("FieldTypeId");

            builder.HasOne(e => e.FieldValidationRule)
                .WithMany()
                .HasForeignKey("CustomValidationId");

            builder.HasOne(e => e.Tag)
                .WithMany(e => e.FormFields)
                .HasForeignKey("TagId");
        }
    }
}
