using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityFramework.Configurations
{
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    { 
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            //builder
            //    .HasKey(p => p.Id)
            //    .HasName("TestsPrimaryKey");

            //builder
            //    .HasAlternateKey(p => p.Name);


            //builder
            //    .HasOne(p => p.Owner)
            //    .WithMany(p => p.Tests)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder
            //    .Property(p => p.Questions)
            //    .IsRequired();

            //builder
            //    .Property(p => p.IsOpen)
            //    .IsRequired()
            //    .HasDefaultValue(false);

        }
    }
}
