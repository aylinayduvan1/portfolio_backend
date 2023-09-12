using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Education : Entity<int>
{
    public string School_name{ get; set; } = default!;
    public string Graduation_data { get; set; } = default!;
    public string Education_text { get; set; } = default!;


}

