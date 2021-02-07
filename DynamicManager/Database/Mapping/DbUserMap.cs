using DynamicManager.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DynamicManager.Database.Mapping
{
    public class DbUserMap : IEntityTypeConfiguration<DbUser>
    {
        public void Configure(EntityTypeBuilder<DbUser> builder)
        {
            builder.ToTable("AspNetUsers").HasNoKey();

            builder.Property(e => e.UserName)
                .HasColumnName("UserName")
                .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Throw);

            builder.Property(e => e.FirstName)
                .HasColumnName("FirstName")
                .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Throw);

            builder.Property(e => e.LastName)
                .HasColumnName("LastName")
                .Metadata.SetBeforeSaveBehavior(PropertySaveBehavior.Throw);
        }
    }
}
