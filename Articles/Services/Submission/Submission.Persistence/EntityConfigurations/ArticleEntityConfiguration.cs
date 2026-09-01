using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Submission.Domain.Entities;
using ArticlesAbstractions.Enums;
using Blocks.EntityFramework;

namespace Submission.Persistence.EntityConfigurations;

internal class ArticleEntityConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnOrder(0);
        builder.Property(e => e.Title).IsRequired().HasMaxLength(256);
        builder.Property(e => e.Scope).IsRequired().HasMaxLength(2048);
        builder.Property(e => e.Stage).HasEnumConversion();
        builder.Property(e => e.Type).HasEnumConversion();
    }
}
