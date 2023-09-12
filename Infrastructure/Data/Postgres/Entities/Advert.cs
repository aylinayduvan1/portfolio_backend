using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Advert : Entity<int>
{
    public string Degree { get; set; } = default!;
    public string Fullname { get; set; } = default!;
    public string Advert_text { get; set; } = default!;


}


