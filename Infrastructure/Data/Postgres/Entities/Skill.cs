
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Skill : Entity<int>
{
    public string Skill_name { get; set; } = default!;
    public string Skill_data { get; set; } = default!;
    

}

