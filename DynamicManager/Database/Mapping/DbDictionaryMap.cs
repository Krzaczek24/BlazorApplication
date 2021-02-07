using DynamicManager.Database.Mapping.Base;
using DynamicManager.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicManager.Database.Mapping
{
    public class DbDictionaryMap : DbBaseTableMap<DbDictionary>, IEntityTypeConfiguration<DbDictionary>
    {
        public DbDictionaryMap(EntityTypeBuilder<DbDictionary> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbDictionary> builder)
        {
            builder.ToTable("Dictionary");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasMaxLength(256);

            builder.Property(e => e.Value)
                .IsRequired()
                .HasColumnName("Value")
                .HasMaxLength(256);

            builder.Property(e => e.Description)
                .HasColumnName("Description")
                .HasMaxLength(4000);

            builder.HasOne(e => e.Parent)
                .WithMany(e => e.Children)
                .HasForeignKey("ParentId");
        }
    }
}
