using DynamicForms.Database.Mapping.Base;
using DynamicForms.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicForms.Database.Mapping
{
    public class DbFormMap : DbBaseTableMap<DbForm>, IEntityTypeConfiguration<DbForm>
    {
        public DbFormMap(EntityTypeBuilder<DbForm> builder) : base(builder) { }

        public void Configure(EntityTypeBuilder<DbForm> builder)
        {
            builder.ToTable("Form");

            builder.HasOne(e => e.FormTemplate)
                .WithMany(e => e.Forms)
                .HasForeignKey("TemplateId");
        }
    }
}
