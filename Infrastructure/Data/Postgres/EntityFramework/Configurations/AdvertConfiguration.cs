using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class AdvertConfiguration : Configuration<Advert, int>
    {
        public override void Configure(EntityTypeBuilder<Advert> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Degree).IsRequired();
            builder.Property(x => x.Fullname).IsRequired();
            builder.Property(x => x.Advert_text).IsRequired();
        }
    }
}