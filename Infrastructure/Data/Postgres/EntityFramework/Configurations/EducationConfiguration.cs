using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class EducationConfiguration : Configuration<Education, int>
    {
        public override void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.School_name).IsRequired();
            builder.Property(x => x.Education_text).IsRequired();
            builder.Property(x => x.Graduation_data).IsRequired();
        }
    }
}