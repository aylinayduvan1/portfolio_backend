
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CommentConfiguration : Configuration<Comment, int>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Comment_userName).IsRequired();
            builder.Property(x => x.Comment_email).IsRequired();
            builder.Property(x => x.Comment_content).IsRequired();
        }
    }
}