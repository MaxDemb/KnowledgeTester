using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace DAL.EntityFramework.Configurations
{
   public class ResultConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {


            builder
                .HasOne(n => n.Test)
                .WithMany(p => p.Results)
                .HasForeignKey(n => n.TestId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(n => n.Student)
                .WithMany(n => n.Results)
                .HasForeignKey(n => n.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder
            //        .HasOne(p => p.UserProfile)
            //        .WithMany(up => up.Notifications)
            //        .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
