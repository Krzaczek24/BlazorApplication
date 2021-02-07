using DynamicManager.Database.Mapping.Base;
using DynamicManager.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicManager.Database.Mapping
{
    public class DbFieldValidationRuleMap : DbBaseTableMap<DbFieldValidationRule>, IEntityTypeConfiguration<DbFieldValidationRule>
    {
        public DbFieldValidationRuleMap(EntityTypeBuilder<DbFieldValidationRule> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbFieldValidationRule> builder)
        {
            builder.ToTable("FieldValidationRule");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(256);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("Description")
                .HasMaxLength(256);

            builder.Property(e => e.Pattern)
                .IsRequired()
                .HasColumnName("Pattern")
                .HasMaxLength(256);

            builder.Property(e => e.Message)
                .IsRequired()
                .HasColumnName("Message")
                .HasMaxLength(256);

            builder.HasOne(e => e.FieldType)
                .WithMany(e => e.ValidationRules)
                .HasForeignKey("FieldTypeId");
        }
    }
}
