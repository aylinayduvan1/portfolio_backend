using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class SkillConfiguration : Configuration<Skill, int>
    {
        public override void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Skill_name).IsRequired();
            builder.Property(x => x.Skill_data).IsRequired();
        }
    }
}