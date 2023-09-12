using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Comment : Entity<int>
{
    public string Comment_userName { get; set; } = default!;
    public string Comment_email { get; set; } = default!;
    public string Comment_content { get; set; } = default!;
  
}

