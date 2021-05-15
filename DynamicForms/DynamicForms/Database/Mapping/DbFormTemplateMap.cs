using DynamicForms.Database.Mapping.Base;
using DynamicForms.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping
{
    public class DbFormTemplateMap : DbBaseTableMap<DbFormTemplate>, IEntityTypeConfiguration<DbFormTemplate>
    {
        public DbFormTemplateMap(EntityTypeBuilder<DbFormTemplate> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbFormTemplate> builder)
        {
            builder.ToTable("FormTemplate");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(256);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasMaxLength(256);

            builder.HasOne(e => e.PreviousVersion)
                .WithMany()
                .HasForeignKey("PreviousVersionId");

            builder.HasOne(e => e.Tag)
                .WithMany(e => e.FormTemplates)
                .HasForeignKey("TagId");
        }
    }
}
