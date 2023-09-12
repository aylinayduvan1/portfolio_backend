using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class ExperienceConfiguration : Configuration<Experience, int>
    {
        public override void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Company).IsRequired();
            builder.HasIndex(x => x.Company).IsUnique();
            builder.Property(x => x.Experience_img).IsRequired();
            builder.HasIndex(x => x.Experience_img).IsUnique();
            builder.Property(x => x.Company_experience).IsRequired();
            builder.Property(x => x.Experience_skill).IsRequired();
            builder.Property(x => x.Experience_data).IsRequired();

        }
    }
}