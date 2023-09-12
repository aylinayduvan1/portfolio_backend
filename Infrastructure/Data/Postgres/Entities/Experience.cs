
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Experience : Entity<int>
{
    public string Company { get; set; } = default!;
    public string Company_experience { get; set; } = default!;
    public string Experience_data { get; set; } = default!;
    public string Experience_skill { get; set; } = default!;
    public string Experience_img { get; set; } = default!;

}

