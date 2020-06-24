using DAL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EntityFramework.Configurations
{
    public class AnswerVariantConfiguration : IEntityTypeConfiguration<AnswerVariant>
    {
        public void Configure(EntityTypeBuilder<AnswerVariant> builder)
        {
        }
    }
}
