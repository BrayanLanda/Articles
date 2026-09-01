using Blocks.EntityFramework.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Submission.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Submission.Persistence.EntityConfigurations
{
    internal class JournalEntityConfiguration : EntityConfiguration<Journal>
    {
        public override void Configure(EntityTypeBuilder<Journal> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(64);
            builder.Property(e => e.Abreviation).IsRequired().HasMaxLength(8);
        }
    }
}
